using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // this is a reference for the RigidBody component called rb
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start() // It will run once when your game starts
    //{
        //Debug.Log("Hello, World!");

        //rb.useGravity = false;
    //}

    // Update is called once per frame
    void FixedUpdate() // Unity like FixedUpdate() instead of Update() for doing physics stuff like forces, gravity, torque, etc.
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // for constant frame rate across different devices

        // Reccommended method for input would be to do that in Update() method 
        // Then store that in a variable. like two booleans moreRight and moveLeft which are set to true when the key is pressed and set to false when key is released
        // then put that bool variable here.
        // But dont worry above it right now, just try to have fun along the way 


        if (Input.GetKey("d")) // moving right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) // moving left
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
