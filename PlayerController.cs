using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerController : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
		// Invert the z and w of the gyro attitude
		Quaternion rotFix = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
		
		// Now set the local rotation of the child camera object
		transform.localRotation = rotFix;
		
		//Walk "forward" in direction that camera is pointing
		
		float distance = 1.0F;
		Vector3 new_position = transform.position + transform.forward * distance * Time.deltaTime;
		
		float MIN_X = -8.0F;
		float MAX_X = 8.0F;
		float MIN_Y = 1.0F;
		float MAX_Y = 5.0F;
		float MIN_Z = -8.0F;
		float MAX_Z = 8.0F;
		
		transform.position = new Vector3(
		    Mathf.Clamp(new_position.x, MIN_X, MAX_X),
		    Mathf.Clamp(new_position.y, MIN_Y, MAX_Y),
		    Mathf.Clamp(new_position.z, MIN_Z, MAX_Z));
		
//		transform.position = new_position;
//		float moveHorizontal = Input.GetAxis("Horizontal");
//        float moveVertical = Input.GetAxis("Vertical");
//
//        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);
		rb.AddForce(transform.position * speed);

    }



//	void FixedUpdate()
//	{
//		float moveHorizontal = Input.GetAxis("Horizontal");
//		float moveVertical = Input.GetAxis("Vertical");
//
//		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
//
//		rb.AddForce(movement * speed);
//	}


//	    void Start()
//	    {
//	        camParent = new GameObject("CamParent");
//	        Input.gyro.enabled = true;
//	
//	        camParent.transform.position = transform.position;
//	        transform.parent = camParent.transform;
//	
//	        // Rotate the parent object by 90 degrees around the x axis
//	        camParent.transform.Rotate(Vector3.right, 90);
//	
//	        transform.position = new Vector3(0, 1, 0);
//	    }
//	
//	    void Update()
//	    {
//	        // Invert the z and w of the gyro attitude
//	        Quaternion rotFix = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
//	
//	        // Now set the local rotation of the child camera object
//	        transform.localRotation = rotFix;
//	        
//	        //Walk "forward" in direction that camera is pointing
//	
//	        float distance = 1.0F;
//	        Vector3 new_position = transform.position + transform.forward * distance * Time.deltaTime;
//	
//	        float MIN_X = -8.0F;
//	        float MAX_X = 8.0F;
//	        float MIN_Y = 1.0F;
//	        float MAX_Y = 100.0F;
//	        float MIN_Z = -8.0F;
//	        float MAX_Z = 8.0F;
//	
//	        transform.position = new Vector3(
//	            Mathf.Clamp(new_position.x, MIN_X, MAX_X),
//	            Mathf.Clamp(new_position.y, MIN_Y, MAX_Y),
//	            Mathf.Clamp(new_position.z, MIN_Z, MAX_Z));
//	
//	        transform.position = new_position;
//	    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}