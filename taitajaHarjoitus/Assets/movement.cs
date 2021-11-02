using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 dir = new Vector2(2, 0);
        rb.AddForce(dir);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, 200), ForceMode2D.Impulse);
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.CompareTag("Ground"))
        {
            print("hell");
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
