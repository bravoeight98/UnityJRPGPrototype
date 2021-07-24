using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4.0f;
    private Rigidbody2D rb;
    private Vector3 change;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxis("Horizontal"); 
        change.y = Input.GetAxis("Vertical"); 
        if(change != Vector3.zero)
        {
            MovePlayer();
        }
    }
    void MovePlayer()
    {
        rb.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
