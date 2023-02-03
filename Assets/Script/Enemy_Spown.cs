using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spown : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefabs;
    public Transform[] SpownPoints;
    public float SpownTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spown",SpownTime,SpownTime);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void Spown()
    {
        int spownIndex = Random.Range(0, SpownPoints.Length);
        Transform spownPoint = SpownPoints[spownIndex];
        Instantiate(_enemyPrefabs, spownPoint.position, spownPoint.rotation);
    }
   
}
