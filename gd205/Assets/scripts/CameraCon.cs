using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{

    public Transform camTarget;
    public float pLerp = .02f;
    public float rLerp = .01f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
    }

    /* Lerps is interpolation between two points. */

}
