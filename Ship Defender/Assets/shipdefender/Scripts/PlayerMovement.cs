using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour {

    
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

	public float forwardForce = 2000f;	// Variable that determines the forward force
	public float sidewaysForce = 500f;  // Variable that determines the sideways force
    //public float dirX;
    private float ScreenWidth;
   
    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate ()
	{
        ScreenWidth = Screen.width;
		// Add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        int i = 0;
        while (i < Input.touchCount)
        {
            if (rb.position.x > 6.999837)
            {
                transform.position = new Vector3(7, transform.position.y, transform.position.z);

            }
            if (rb.position.x < -6.999797)
            {
                transform.position = new Vector3(-7, transform.position.y, transform.position.z);

            }
            //dirX = Input.acceleration.x * sidewaysForce;

            //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7f, 7f));
            if (rb.position.y < -1f)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }


            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            ++i;
        }
       

        if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //print(transform.position.x);
        }

        
        if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
            // Add a force to the left

            //print(transform.position);
            
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
		}
        if (rb.position.x > 6.999837)
        {
            transform.position = new Vector3(7, transform.position.y, transform.position.z);
            
        }
        if (rb.position.x < -6.999797)
        {
            transform.position = new Vector3(-7, transform.position.y, transform.position.z);

        }
        //dirX = Input.acceleration.x * sidewaysForce;
        
        //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7f, 7f));
        if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}

	}
    //void Update()
    //{
      //  rb.velocity = new Vector2(dirX, 0F);

    //}
}



//public Joystick joystick;
//public float horizontalMove = 0f;
//horizontalMove = joystick.Horizontal * forwardForce;
// || Input.GetButtonDown("Horizontal")