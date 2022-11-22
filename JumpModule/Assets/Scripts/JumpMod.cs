using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMod : MonoBehaviour
{
    [SerializeField] int maxCounter = 3;
    int counter;
    [SerializeField] Rigidbody rb;
    [SerializeField] int jumpForce = 30;
    [SerializeField] int layer = 6;

    public void Jump()
    {
        if (counter < maxCounter)
        {
            rb.AddForce(transform.up * jumpForce);
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
