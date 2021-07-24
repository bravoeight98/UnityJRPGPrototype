using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2d rb;
    private Vector2 change;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2d>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;   
    }
}
