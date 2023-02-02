using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int DisplayScore;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);
        transform.position = transform.position + (Vector3)(direction * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ebulat"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
    public void UpdateScor(int DethCount)
    {
        DisplayScore += DethCount;
        if (DisplayScore == 2)
        {
            
            speed *=2 ;
        }
    }
}
