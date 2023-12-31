
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class AsteroidManager : MonoBehaviour
{

    //Particle System explosion
    public GameObject explosion;

    //Splitting
    public GameObject asteroidToSplitInto;
    public int splitRate = 1;
    public float splitSpeed = 1.0f;

    //Camera
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Vector3 posicionViewport = cam.WorldToViewportPoint(transform.position);

        if(posicionViewport.x > 2 || posicionViewport.x < -1 || posicionViewport.y > 2 || posicionViewport.y < -1)
        {
            Destroy(gameObject);
        }
    }

      
    

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {


        //If not collided with ship then instantiate the particles
        if (GameObject.FindGameObjectsWithTag("Bullet").Contains(collision.gameObject))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            //Change Score
            ChangeScore.instance.changeScore();

            var smng = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
            smng.PlayAsteroid();
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);

            if(asteroidToSplitInto != null)
            {
                for (int i = 0; i < splitRate; i++)
                {
                    float randomX = Random.Range(-1f, 1f);
                    float randomY = Random.Range(-1f, 1f);

                    GameObject newAsteroid = Instantiate(asteroidToSplitInto, gameObject.transform.position, gameObject.transform.rotation);
                    newAsteroid.GetComponent<Rigidbody2D>().velocity = new Vector2(randomX, randomY) * splitSpeed;
                }
            }

            

        }

    }


}
