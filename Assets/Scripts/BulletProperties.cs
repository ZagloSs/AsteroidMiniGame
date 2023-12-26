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
        //Call to another's script funciton
        cs.changeScore();
        
        //Destroy both collisionated and itself
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
