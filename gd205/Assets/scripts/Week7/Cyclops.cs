using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclops : MonoBehaviour
{

    public float boomBoom = 5f;
    public float boomBlast = 6f;
    public GameObject prefab;


    void FixedUpdate()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(laser, out hit)){
            
            if(Input.GetMouseButton(0) && g){
                Destroy(gameObject);

            }
            
        }
    }
}

            
            /*
            //Debug.Log("you hit a ball:" + hit.transform.name);
            if(Input.GetMouseButton(0) && hit.rigidbody ){

                hit.rigidbody.AddExplosionForce(boomBoom, hit.point, boomBlast);
                   

            }

        }

        if(Input.GetMouseButtonDown(1)){
               
          Instantiate(prefab,hit.point, Quaternion.identity);
        }

        */

            
    


