using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    
    public GameObject Capsule;
    public GameObject ufo;
    public float speed;


    // Update is called once per frame
    void Update()
    {
          Capsule.transform.position= Vector3.MoveTowards(Capsule.transform.position, ufo.transform.position,speed);

    }
}
