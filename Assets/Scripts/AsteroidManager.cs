
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

    private ChangeScore cs;

    //Camera
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
        cs = GameObject.FindGameObjectWithTag("Score").GetComponent<ChangeScore>();
    }

    private void Update()
    {
        Vector3 posicionViewport = cam.WorldToViewportPoint(transform.position);

        if(posicionViewport.x > 1.3 || posicionViewport.x < -0.3 || posicionViewport.y > 1.3 || posicionViewport.y < -0.3)
        {
            Destroy(gameObject);
        }
    }

      
    

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {


        //If not collided with ship then instantiate the particles
        if (collision.gameObject == GameObject.FindGameObjectWithTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            cs.changeScore();

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
