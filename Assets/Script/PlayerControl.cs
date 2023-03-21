using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10.0f;

    public Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp))
        {
            Debug.Log("kepencet W");
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            Debug.Log("Kepencet S");
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;

            
    }
}
