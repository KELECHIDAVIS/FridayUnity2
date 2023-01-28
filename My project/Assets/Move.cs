using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    public float walkSpeed = 5;
    public float runSpeed = 10;
    private float speed;
    public Rigidbody rb;  // players rb

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed; 
        }else
        {
            speed = walkSpeed; 
        }
        //Checks our user Input on the Horizontal and Vertical Axis, multiplied by our speed and the time that has passed (This will move our player smoothly around the map)
        float inputX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float inputZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //Moves our Rigidbody with our inputted axis's 
        rb.transform.Translate(inputX, 0, inputZ);
    }
}
