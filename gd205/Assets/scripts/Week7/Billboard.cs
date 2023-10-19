using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
  

  /*
[SerializeField] private BillboardType billboardType;

 [Header("Lock Rotation")]
  [SerializeField] private bool lockX;
  [SerializeField] private bool lockY;
  [SerializeField] private bool lockZ;

    private Vector3 originalRotation;
public enum BillboardType { LookAtCamera};


private void Awake() {
    originalRotation = transform.rotation.eulerAngles;
  }
*/


public float speed;

[SerializeField]
private GameObject player;



void Start(){

  player = GameObject.FindGameObjectWithTag("Player");

}
  void Update(){

      transform.position = Vector3.MoveTowards(transform.position, player.transform.position,speed);  



    }


    /* this wouldve been cooler if the camera wasnt static but this allows for the bear to always face the camera 

    void LateUpdate(){
        switch (billboardType){
        case BillboardType.LookAtCamera:
        transform.LookAt(Camera.main.transform.position,Vector3.up);
        break;
        }

    Vector3 rotation = transform.rotation.eulerAngles;
    if (lockX) { rotation.x = originalRotation.x; }
    if (lockY) { rotation.y = originalRotation.y; }
    if (lockZ) { rotation.z = originalRotation.z; }
    transform.rotation = Quaternion.Euler(rotation);

    }

  */
    

}


