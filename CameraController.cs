using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    // Create a parent object containing the camera (you could do this manually in the 
    // hierarchy if preferred, or here in code)
    GameObject camParent;



	/* Camera follows gyro */
//    void Start()
//    {
//        camParent = new GameObject("CamParent");
//        Input.gyro.enabled = true;
//
//        camParent.transform.position = transform.position;
//        transform.parent = camParent.transform;
//
//        // Rotate the parent object by 90 degrees around the x axis
//        camParent.transform.Rotate(Vector3.right, 90);
//
//        transform.position = new Vector3(0, 1, 0);
//    }
//
//    void Update()
//    {
//        // Invert the z and w of the gyro attitude
//        Quaternion rotFix = new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
//
//        // Now set the local rotation of the child camera object
//        transform.localRotation = rotFix;
//        
//        //Walk "forward" in direction that camera is pointing
//
//        float distance = 1.0F;
//        Vector3 new_position = transform.position + transform.forward * distance * Time.deltaTime;
//
//        float MIN_X = -8.0F;
//        float MAX_X = 8.0F;
//        float MIN_Y = 1.0F;
//        float MAX_Y = 100.0F;
//        float MIN_Z = -8.0F;
//        float MAX_Z = 8.0F;
//
//        transform.position = new Vector3(
//            Mathf.Clamp(new_position.x, MIN_X, MAX_X),
//            Mathf.Clamp(new_position.y, MIN_Y, MAX_Y),
//            Mathf.Clamp(new_position.z, MIN_Z, MAX_Z));
//
//        transform.position = new_position;
//    }
//









	/* Doesn't work */
//
//    
//        void Start()
//        {
//            Input.gyro.enabled = true;
//        }
//
//        void Update()
//        {
//            var x = Input.gyro.rotationRateUnbiased.x;
//            transform.eulerAngles = new Vector3(x, 0, 0);
//        }
//        
//


	/* Camera follows player*/
    
    void Start()
    {
        offset = transform.position - player.transform.position;
		//offset = 0.0f;
	}

    void LateUpdate()
    {
		transform.position = player.transform.position  ;//+ offset;
    }
    



	/* Camera follows arrow key*/

//    void Start()
//    {
//
//    }
//
//    private void Update()
//    {
//        float moveHorizontal = Input.GetAxis("Horizontal");
//        float moveVertical = Input.GetAxis("Vertical");
//
//        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
//
//        transform.position = transform.position + movement / 2.0F;
//
//
//        //rb.AddForce(movement * speed);
//    }
//
//
}