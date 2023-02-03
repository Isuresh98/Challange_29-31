using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitlyPlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject BulatPrefabs;
    public float BulatSpeed=10f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    private void Shoot()
    {

        if (gameObject.tag == "Player1")
        {
            if (Input.GetKey(KeyCode.RightControl))
            {
                BulatInsta();
            }
        }
        if (gameObject.tag == "Player2")
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                BulatInsta();
            }
        }

    }

    private void BulatInsta()
    {
        GameObject Bulat = Instantiate(BulatPrefabs, transform.position, Quaternion.identity);
        Bulat.GetComponent<Rigidbody2D>().velocity = transform.position * BulatSpeed;
    }
    
}
