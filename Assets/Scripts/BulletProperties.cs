using System.Linq;
using UnityEngine;

public class BulletProperties : MonoBehaviour
{
    public float life = 3;

    private ChangeScore cs;

    private void Start()
    {
        //Change score script instance
        cs = GameObject.FindGameObjectWithTag("Score").GetComponent<ChangeScore>();
    }


    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (GameObject.FindGameObjectsWithTag("Asteroid").Contains(collision.gameObject))
        {
            //Call to another's script funcitons
            cs.changeScore();

            //Destroy both collisionated and itself
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
