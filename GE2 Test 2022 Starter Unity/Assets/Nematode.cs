using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 20;

    public Material material;

    public GameObject spherePrefab;

    void Awake()
    {
        // Put your code here!
         int radius = 5;
        float offset = 0;

        // //generating 10 cubes
        for(int i = 0; i < length; i++)
        {
            // float theta = (2.0f * Mathf.PI) / 10;
            // float angle = theta * i;

        // //     //get x and y positions of cube
        //     float x = Mathf.Sin(angle) * radius * 2.1f;
        //     float y = Mathf.Cos(angle) * radius * 2.1f;

            GameObject sphere = GameObject.Instantiate<GameObject>(spherePrefab);

            //set position of the cube
            sphere.transform.position = transform.TransformPoint(new Vector3(0,0,i));
           
            sphere.transform.parent = this.transform;
            // offset = offset + .2f;
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


