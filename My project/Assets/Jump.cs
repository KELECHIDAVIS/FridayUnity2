using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpStrength = 5;
    bool isGrounded = false;
    public Rigidbody rb;
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            isGrounded = true; 
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            isGrounded = false;
        }
    }
    // Update is called once per frame
    void Update()//Update is running every frame 
    {
        //Checks if the player presses the jumpKey and is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //if so add upward force to the players rigidbody 
            rb.AddForce(rb.transform.up * jumpStrength, ForceMode.Impulse);
            Debug.Log("forehead"); 
        }
    }
}
