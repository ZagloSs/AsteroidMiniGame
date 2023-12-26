using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ExplodingObstacles : MonoBehaviour
{
    public GameObject explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject != GameObject.FindGameObjectWithTag("Ship"))
        {
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
        }

       
    }


}
