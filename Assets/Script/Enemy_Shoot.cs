using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public Transform player;
    private AudioSource audioSource;
    public AudioClip enemyShootSound;
    public float shootTime = 2f;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        audioSource = GetComponent<AudioSource>();
        currentTime = shootTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            Shoot();
            currentTime = shootTime;
        }
    }
    private void Shoot()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = direction * bulletSpeed;
        audioSource.clip = enemyShootSound;
        audioSource.Play();
        Destroy(bullet, 2f);
    }
}
