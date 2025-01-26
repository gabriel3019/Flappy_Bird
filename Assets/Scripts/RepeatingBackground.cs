using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontallength;



    void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }

    void Start()
    {
        groundHorizontallength = groundCollider.size.x;
    }

    private void RepositionBackground()
    {
        transform.Translate(Vector2.right * groundHorizontallength * 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -groundHorizontallength)
        {
            RepositionBackground();
        }
    }
}
