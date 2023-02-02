using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spown : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public float spawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void Spawn()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
