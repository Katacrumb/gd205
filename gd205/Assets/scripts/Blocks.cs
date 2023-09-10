using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player"){
        isFalling = true;
         Destroy(gameObject,10);
        
    }
    }
    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime/25;
            transform.position = new Vector3(transform.position.x,
            transform.position.y-downSpeed,
            transform.position.z);

        }
    }
}
