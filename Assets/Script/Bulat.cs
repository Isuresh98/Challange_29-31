using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulat : MonoBehaviour
{
    private Movement playerScoreScript;
    public int DethCount;
    // Start is called before the first frame update
    void Start()
    {
        playerScoreScript = FindObjectOfType<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DethCount++;
            playerScoreScript.UpdateScore(DethCount);
        }
    }

}
