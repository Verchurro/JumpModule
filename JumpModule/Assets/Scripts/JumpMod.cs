using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMod : MonoBehaviour
{
    [SerializeField] bool isGrounded;
    [SerializeField] bool jump;
    [SerializeField] int maxCounter = 3;
    [SerializeField] int counter = 0;
    [SerializeField] Rigidbody rb;
    [SerializeField] int jumpForce = 30;
    [SerializeField] int layer = 6;
    void Update()
    {
        if (isGrounded)
        {
            maxCounter = 0;
        }

        if (counter >= maxCounter)
        { return; }

        //adding force upwards to create a jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
            jump = true;
            counter++;
        }

    }
    //reset the counter whenever we land
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            counter = 0;
        }
    }
}
