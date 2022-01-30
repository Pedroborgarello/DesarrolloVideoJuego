using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float spawnInterval;
    [SerializeField] float spawnDelay;
    void Start()
    {
        InvokeRepeating("SpawnBullet", spawnDelay, spawnInterval);
          
    }

    
    void Update()
    {
        
    }

    private void SpawnBullet()
    {
        Instantiate(bullet, transform);
    }
}
