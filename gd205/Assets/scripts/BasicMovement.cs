using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public GameObject hazard;
    public GameObject[] hazards;


    // Start is called before the first frame update
    void Start()
    {
        
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
        // the transform.forward = vector3.x; is meant to be used so that when a key is pressed in a direction
        //it faces that way.
        /*
         if (transform.position == hazard.transform.position){
            Debug.Log("This is a hazard): it hurt!");
            Destroy(gameObject);
    
        }
        */

        for (int i = 0; i < hazards.Length; i++){
            if (transform.position == hazards.transform.position){
            Debug.Log("This is a hazard): it hurt!");
            Destroy(gameObject);
        }

    }
}

