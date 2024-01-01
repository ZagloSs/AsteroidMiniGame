using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{

    public float bulletSpeed = 10;
    public GameObject bulletPrefab;

    public Transform bulletSpawnPointUp;
    public Transform bulletSpawnPointDown;
    public Transform bulletSpawnPointRight;
    public Transform bulletSpawnPointLeft;





    // Update is called once per frame
    void Update()
    {
        var smng = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            smng.PlayShooting();

            var bulletUp = Instantiate(bulletPrefab, bulletSpawnPointUp);
            bulletUp.GetComponent<Rigidbody2D>().velocity = bulletSpawnPointUp.up * bulletSpeed;

        }
    }
}
