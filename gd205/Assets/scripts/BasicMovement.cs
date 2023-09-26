using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    
    public GameObject[] hazards;
    Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W)){
            
            transform.position += Vector3.forward;
            transform.forward = Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S)){
           
            transform.position += Vector3.back;
            transform.forward = Vector3.back;
        }
        if(Input.GetKeyDown(KeyCode.A)){
            
            transform.position += Vector3.left;
            transform.forward = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D)){
            
            transform.position += Vector3.right;
            transform.forward = Vector3.right;
        }
        

        

    }
}

