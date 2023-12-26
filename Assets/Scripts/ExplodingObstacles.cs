using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class ExplodingObstacles : MonoBehaviour
{

    //Particle System explosion
    public GameObject explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //If not collided with ship then instantiate the particles
        if(collision.gameObject != GameObject.FindGameObjectWithTag("Ship"))
        {

            var smng = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();

            smng.PlayAsteroid();

            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);

           
        }

       
    }


}
