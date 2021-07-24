using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector3 change;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxis("Horizontal"); 
        change.y = Input.GetAxis("Vertical"); 
        UpdateAnimationMovement();
    }

    void UpdateAnimationMovement()
    {
        if(change != Vector3.zero)
        {
            MovePlayer();
            anim.SetFloat("moveX", change.x);
            anim.SetFloat("moveY", change.y);
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking",false);
        }
    } 

    void MovePlayer()
    {
        rb.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
