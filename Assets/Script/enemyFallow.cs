using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFallow : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform player;
    public float stopDistance = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        if (distance > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bulat"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
           

        }
    }

}
