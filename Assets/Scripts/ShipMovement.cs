using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _rb;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if(hor != 0 || ver != 0)
        {
            Vector2 velocity = new Vector2(hor, ver).normalized * speed;

           _rb.velocity = velocity;
        }
        else
        {
            _rb.velocity = Vector2.zero;
        }

    }
}
