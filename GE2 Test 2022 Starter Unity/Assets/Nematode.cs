using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length;

    public Material material;

    public GameObject spherePrefab;

    [SerializeField] Color[] myColors;

    void Awake()
    {
        // Put your code here!
        length = Random.Range(8,25);
        int radius = 5;
        float offset = 0;

        // //generating 10 cubes
        for(int i = 0; i < length; i++)
        {
            
            GameObject sphere = GameObject.Instantiate<GameObject>(spherePrefab);

            //set position of the cube
            sphere.transform.parent = this.transform;
            sphere.transform.position = transform.TransformPoint(new Vector3(0,0,i));
            

            // sphere.transform.localScale = new Vector3(2.5f,2.5f,2.5f);
              sphere.transform.localScale = new Vector3(1.5f,1.5f,1.5f);

            // if(i <2 )
            // {
            //     sphere.transform.localScale = new Vector3(i,i,1.5f);
            //      // SphereMeshRenderer.material.color = Color.Lerp(SphereMeshRenderer.material.color, myColors[colorIndex], lerpTime*Time.deltaTime);



            // }
            // else if( i > 13)
            // {
            //     sphere.transform.localScale = new Vector3((length - i)/5, (length - i)/5, 1.5f);
            // }

            Debug.Log("size at " + i + " is " + sphere.transform.localScale);
            offset = offset + .2f;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


