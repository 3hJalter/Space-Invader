using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rigidbody;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // update horizontal axis input (get A or D when pressed)
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal is: " + horizontal);
        // update vertical axis input (get W or S when pressed)
        float vertical = Input.GetAxis("Vertical");
        Debug.Log("Vertical is: " + vertical);
        Vector2 direction = new Vector2(horizontal, vertical);

        rigidbody.velocity = direction.normalized * speed;

        animator.SetBool("isFlyingLeft", (horizontal < 0));

        animator.SetBool("isFlyingUp", (vertical > 0));

        animator.SetBool("isFlyingRight", (horizontal > 0));
        
    }
}
