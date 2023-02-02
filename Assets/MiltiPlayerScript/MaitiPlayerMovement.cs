using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaitiPlayerMovement : MonoBehaviour
{
    public int DisplayScore;
    public float speed = 10f;
    float horizontal;
    float vertical;
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
        

        if (gameObject.tag == "Player1")
        {
            horizontal = Input.GetAxis("Horizontal1");
            vertical = Input.GetAxis("Vertical1");
        }
        if (gameObject.tag == "Player2")
        {
            horizontal = Input.GetAxis("Horizontal2");
            vertical = Input.GetAxis("Vertical2");
        }
        

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
            speed *= 2;
        }
    }
}
