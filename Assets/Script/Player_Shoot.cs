using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
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
    }
    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector2 roundedPos = new Vector2(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));

            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Vector2 direction = (roundedPos - (Vector2)transform.position).normalized;
            rb.velocity = direction * bulletSpeed;
            Destroy(bullet, 2f);
            audioSource.clip = playerShootSound;
            audioSource.Play();

            //Rotate the player towards the mouse position
            Vector3 dir = mousePos - Camera.main.WorldToScreenPoint(transform.position);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}






