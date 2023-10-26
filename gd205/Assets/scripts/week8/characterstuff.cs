using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterstuff : MonoBehaviour
{


    CharacterController controller;
    Animator anim;
    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();


    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        //Debug.Log(move);

        anim.SetFloat("Movement", move.z);
        controller.Move(move * speed * Time.deltaTime);


        if (Input.GetKey(KeyCode.LeftShift)){
            anim.SetBool("isRunning", true);
            controller.Move(move * speed * Time.deltaTime);


        } else {
        anim.SetBool("isRunning",false);
    
        }
        //this shit does not work im clueless on why it doesnt
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift)){
           anim.SetFloat("isRunningBackwards", move.z);
           controller.Move(move * speed * Time.deltaTime);

            }

        if(Input.GetKey(KeyCode.R)){
            anim.SetBool("Punch",true);
        }else{
            anim.SetBool("Punch",false);
        }
    }
      
      
      
}


