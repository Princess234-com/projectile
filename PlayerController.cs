using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;



public class PlayerController : MonoBehaviour
{
    //This is my camera lerp

   
    public float speed = 15f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    public float speedH = 2.0f;
    public float speedV = 2.0f;
     private float yaw = 0.0f;
    private float pitch = 0.0f;
    private object toggle;

    //public float ShakeIntensity { get; private set; }
    //public float ShakeDecay { get; private set; }
    //public bool Shaking { get; private set; }
    //public Vector3 OriginalPos { get; private set; }
    //public Quaternion OriginalRot { get; private set; }

    // You can also replace the verticalInput with ForwardInput.Just remember to replace it everywhere
    // Start is called before the first frame update
    void Start()
    {

        // Update is called once per frame
        void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Move the vehicle Camera
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // To rotate the Camera
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        // To move the camera up and down with mouse
        //https://gamedev.stackexchange.com/questions/104693/how-to-use-input-getaxismouse-x-y-to-rotate-the-camera
       
            {
                yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
}

    //private void DoShake()
    //{
    //    OriginalPos = transform.position;
    //    OriginalRot = transform.rotation;

    //    ShakeIntensity = 0.3f;
    //    ShakeDecay = 0.02f;
    //    Shaking = true;

    }

    


