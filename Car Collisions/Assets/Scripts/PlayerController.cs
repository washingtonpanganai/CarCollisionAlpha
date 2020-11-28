using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    public float leftBoundary = -20f;
    public float rightBoundary = 58f;
    public bool isOnGround = false;
    public bool gameOver;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBoundary)
        {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rightBoundary)
        {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * forwardInput);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
      
            if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
            } else if (collision.gameObject.CompareTag("cars"))
            {

                Debug.Log("Game Over");
                gameOver = true;
            }
    }
        
}
