using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField]float dropTime = 5f;
    MeshRenderer renderer; 
    Rigidbody rigidbody;
    
    
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > dropTime){
            Debug.Log("5 seconds has elapsed!");
            renderer.enabled = true;
            rigidbody.useGravity = true;

        }
        
    }
    
}
