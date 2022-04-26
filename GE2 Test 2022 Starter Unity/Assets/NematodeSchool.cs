using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    // Start is called before the first frame update
    void Awake()
    {
        // Put your code here

        for(int i = 0; i < count; i++)
        {
            GameObject nema = GameObject.Instantiate<GameObject>(prefab);
            nema.transform.position = transform.TransformPoint(new Vector3(Random.Range(0,30),0,Random.Range(0,30)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
