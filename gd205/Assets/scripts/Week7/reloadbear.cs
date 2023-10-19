using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reloadbear : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Enemy"))
        {
            ScoreScript.scoreValue += 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            
            
        }
            
    }
}
