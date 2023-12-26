using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDeath : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
    }
}
