using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reloadScene : MonoBehaviour
{       

    
    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Enemy "))
        {
            ScoreScript.scoreValue += 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            
            
        }
            
    }
 }

