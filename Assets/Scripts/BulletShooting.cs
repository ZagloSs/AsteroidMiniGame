using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooting : MonoBehaviour
{

    public float bulletSpeed = 10;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint);

            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
        }
    }
}
