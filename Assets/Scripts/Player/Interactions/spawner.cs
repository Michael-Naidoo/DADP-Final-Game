using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject drug;
    public float maxSpawnTime;
    private float spawnTimer;

    private void Start()
    {
        spawnTimer = maxSpawnTime;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Instantiate(drug, transform.position, Quaternion.identity);
            spawnTimer = maxSpawnTime;
        }
    }
}
