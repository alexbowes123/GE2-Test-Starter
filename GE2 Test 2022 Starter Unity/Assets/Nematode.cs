using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length;

    public Material material;

    public GameObject spherePrefab;

    public Renderer sphereMeshRenderer;


 

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
        
            Debug.Log(sphere.name + " is a child of "+this.name);
            sphere.transform.parent = this.transform;
            sphere.transform.position = sphere.transform.parent.TransformPoint(new Vector3(0,0,-i));
            sphere.transform.rotation = this.transform.rotation;
            Debug.Log("sphere pos = "+sphere.transform.position +" and parent pos "+this.transform.position);

            sphereMeshRenderer = sphere.GetComponent<Renderer>();

            //COULD NOT GET THE COLOURS TO CHANGE 
            sphereMeshRenderer.material.color = Color.HSVToRGB(50, i * 10,i * 10);
       

            

            // sphere.transform.localScale = new Vector3(2.5f,2.5f,2.5f);
              sphere.transform.localScale = new Vector3(1.5f,1.5f,1.5f);

            if(i <2 )
            {
                sphere.transform.localScale = new Vector3(i,i,1.5f);
                 // SphereMeshRenderer.material.color = Color.Lerp(SphereMeshRenderer.material.color, myColors[colorIndex], lerpTime*Time.deltaTime);



            }
            else if( i > 13)
            {
                sphere.transform.localScale = new Vector3((length - i)/5, (length - i)/5, 1.5f);
            }

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


