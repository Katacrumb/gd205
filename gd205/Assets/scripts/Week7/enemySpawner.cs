using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float enemyInterval = 3.5f;

    


    void Start()
    {   
        
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
        

    }

   private IEnumerator spawnEnemy(float interval, GameObject enemy)
   {
    yield return new WaitForSeconds(interval);

    GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f,5), Random.Range(1,3f), 0 ), Quaternion.identity);
    
    StartCoroutine(spawnEnemy(interval, enemy));


   }

}
