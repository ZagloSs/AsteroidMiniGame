using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{

    public float bulletSpeed = 10;
    public GameObject bulletPrefab;

    public Transform bulletSpawnPointUp;
    public Transform bulletSpawnPointDown;
    public Transform bulletSpawnPointRight;
    public Transform bulletSpawnPointLeft;

    public Cooldown cooldown;

    private SoundManager smng;


    private void Start()
    {
       smng = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
    }


    // Update is called once per frame
    void Update()
    {

        if (!cooldown.isCoolingDown)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                smng.PlayShooting();

                var bulletUp = Instantiate(bulletPrefab, bulletSpawnPointUp);
                bulletUp.GetComponent<Rigidbody2D>().velocity = bulletSpawnPointUp.up * bulletSpeed;

                cooldown.StartCooldown();
            }
        }
    }
}
