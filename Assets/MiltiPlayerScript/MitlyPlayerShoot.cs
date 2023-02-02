using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitlyPlayerShoot : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    private AudioSource audioSource;
    public AudioClip playerShootSound;
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        mousePos = Input.mousePosition;
    }
    private void Shoot()
    {
        if (gameObject.tag == "Player1")
        {
            if (Input.GetKey(KeyCode.RightControl))
            {
                print("Shoot palyer1");
                audioSource.clip = playerShootSound;
                audioSource.Play();

                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = transform.position * bulletSpeed;

                Destroy(bullet, 2f);

            }


        }
       else if (gameObject.tag == "Player2")
        {
            if (Input.GetKey(KeyCode.LeftControl))

            {
                print("Shoot palyer2");
                audioSource.clip = playerShootSound;
                audioSource.Play();

                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = transform.position * bulletSpeed;
                Destroy(bullet, 2f);

            }


        }

    }
}
