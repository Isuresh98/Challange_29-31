using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulat : MonoBehaviour
{
    private Movement PlayerScore;
    public int DethCount;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScore = FindObjectOfType<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DethCount++;
            PlayerScore.UpdateScor(DethCount);
        }
    }
}
