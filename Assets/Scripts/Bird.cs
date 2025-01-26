using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    private bool isDead;
    private Rigidbody2D rb2d;
    public float upForce = 200f;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead) return;
        
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(Vector2.up * upForce);
            }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
    }
}
