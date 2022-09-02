using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public EnemySpawner enemySpawner;

    private void OnCollisionEnter(Collision collision)
    {
        enemySpawner.enemyCount--;
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        transform.LookAt(new Vector3(0, 0, 0));
        transform.position += transform.right * 0.05f;
    }
}
