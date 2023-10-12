using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhysicsMovement : MonoBehaviour
{

    Rigidbody rb;
    public float forceMultiplier = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(transform.forward * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(-transform.forward * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(-transform.right * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(transform.right * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.Q)){
            rb.AddForce(transform.up * forceMultiplier);
        }
        if (Input.GetKey(KeyCode.E)){
            rb.AddForce(-transform.up * forceMultiplier);
        }

        if (Input.GetKey(KeyCode.LeftShift)){
            rb.velocity *= 0.95f;
        }
    }

    void OnCollisionEnter(Collision col){
        if (col.gameObject.tag != "Victim"){
            rb.useGravity = true;


        if (col.gameObject.tag == "Enemy"){
        
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            }

        }
    }
}