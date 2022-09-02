using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    public int enemyCount = 0;

    void Start()
    {
        InvokeRepeating("spawnEnemy", 2, 1);
    }

    private void spawnEnemy()
    {
        if(enemyCount < 20)
        {
            enemyCount++;
            float angle = Random.Range(0, Mathf.PI * 2);
            Instantiate(enemyPrefab, new Vector3(Mathf.Cos(angle) * 10f, 2, Mathf.Sin(angle) * 10f), Quaternion.identity);
            enemyPrefab.GetComponent<EnemyScript>().enemySpawner = this;
        }
    }
}
