using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ExplodingObstacles : MonoBehaviour
{

    //Particle System explosion
    public GameObject explosion;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Vector3 posicionViewport = cam.WorldToViewportPoint(transform.position);

        if(posicionViewport.x > 1.3 || posicionViewport.x < -0.3 || posicionViewport.y > 1.3 || posicionViewport.y < -0.3)
        {
            Destroy(gameObject);
        }
    }

      
    

    private void OnCollisionEnter2D(Collision2D collision)
    {


        //If not collided with ship then instantiate the particles
        if(collision.gameObject == GameObject.FindGameObjectWithTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            var smng = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
            smng.PlayAsteroid();
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);

        }

    }


}
