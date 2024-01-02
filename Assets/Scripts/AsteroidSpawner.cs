using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject SAsteroid, MAsteroid, XLAsteroid;

    private GameObject[] asteroids;

    public float spawnSpeed = 1.0f;

    public float trajectoryVariance = 15.0f;

    public float spawnRate = 2.0f;

    public float spawnDistance = 15.0f;

    public int spawnAmount = 1;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), this.spawnRate, this.spawnRate);
        asteroids = new GameObject[] {SAsteroid, MAsteroid, XLAsteroid };
    }

    private void Spawn()
    {
        for(int i = 0; i < spawnAmount; i++)
        {
            Vector3 spawnDirection = Random.insideUnitCircle.normalized * this.spawnDistance;
            Vector3 spawnPoint = this.transform.position + spawnDirection;

            float variance = Random.Range(-this.trajectoryVariance, this.trajectoryVariance);
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

            GameObject newAsteroid = Instantiate(asteroids[Random.Range(0,3)], spawnPoint, rotation);
            newAsteroid.GetComponent<Rigidbody2D>().velocity = (rotation * -spawnDirection) * spawnSpeed;

        }
    }
}
