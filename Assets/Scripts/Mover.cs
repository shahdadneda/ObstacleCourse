using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {    
        MovePlayer();
    }

    void PrintInstruction() {
        Debug.Log("Welcome to this Obstical Crouse!");
        Debug.Log("Control your player with WASD");
        Debug.Log("Dont hit the walls!");
    }
    
    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal") *Time .deltaTime *moveSpeed /2;
        float zValue = Input.GetAxis("Vertical") *Time.deltaTime *moveSpeed/2;

        transform.Translate(xValue,0,zValue);

    }
}
