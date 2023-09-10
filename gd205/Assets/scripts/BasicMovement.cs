using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W)){
            print("W key pressed:");
            transform.position += Vector3.forward;
            transform.forward = Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S)){
            print("S key pressed:");
            transform.position += Vector3.back;
            transform.forward = Vector3.back;
        }
        if(Input.GetKeyDown(KeyCode.A)){
            print("A key pressed:");
            transform.position += Vector3.left;
            transform.forward = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D)){
            print("D key pressed:");
            transform.position += Vector3.right;
            transform.forward = Vector3.right;
        }
        // the transform.forward = vector3.x; is meant to be used so that when a key is pressed in a direction
        //it faces that way.
    

    }
}

