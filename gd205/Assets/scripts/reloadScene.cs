using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reloadScene : MonoBehaviour
{       

    public AudioSource restart;
    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            restart.Play();
            
        }
            
    }
 }

