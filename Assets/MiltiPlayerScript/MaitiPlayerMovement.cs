using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaitiPlayerMovement : MonoBehaviour
{
    public float Speed;
    float horizontalInput;
    float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
   
    void Move()
    {
        if (gameObject.tag == "Player1")
        {
            horizontalInput = Input.GetAxis("Horizontal1");
            verticalInput = Input.GetAxis("Vertical1");
        }
        if (gameObject.tag == "Player2")
        {
            horizontalInput = Input.GetAxis("Horizontal2");
            verticalInput = Input.GetAxis("Vertical2");
        }

        Vector2 direction = new Vector2(horizontalInput, verticalInput);

        transform.position = transform.position + (Vector3)(direction * Speed * Time.deltaTime);
    }
}
