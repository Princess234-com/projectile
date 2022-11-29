using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CannonLauncher : MonoBehaviour
{
    // Start is called before the first frame update
    public float launchVelocity = 10f;
    public float launchAngle = 30f;
    public float Gravity = -9.8f;

    public Vector3 v3InitialVelocity;
    public Vector3 v3CurrentVelocity;
    public Vector3 v3AccelerationVelocity;

    private float airTime = 0f;
    private float xDisplacement = 0f;

    private bool simulate = false;
    private Vector3 v3Acceleration;

    void Start()
    {
        CalculateProjectile();
    }
        private void CalculateProjectile()
        {
            //workout velocity as vector quantity
            v3InitialVelocity.z = launchVelocity * Mathf.Cos(launchAngle * Mathf.Deg2Rad);
            v3InitialVelocity.y = launchVelocity * Mathf.Sin(launchAngle * Mathf.Deg2Rad);
            //gravity as a vector
            v3Acceleration = new Vector3(0f, Gravity, 0f);

            //calculate total time in air
            float finalYVel = 0f;
            airTime = 2f * (finalYVel - v3InitialVelocity.y) / v3AccelerationVelocity.y;

//calculate total disance travelled in x
xDisplacement = airTime * v3AccelerationVelocity.z;
        }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (simulate)
        {
            Vector3 currentPos = transform.position;
            //work out current velocity
            v3CurrentVelocity += v3Acceleration * Time.fixedDeltaTime;
            //work out displacement
            Vector3 displacement = v3CurrentVelocity * Time.fixedDeltaTime;
            currentPos += displacement;
            transform.position = currentPos;
        }
    }


    private float zDisplacement = 0f;
    void Update()
    {
       Forc
        if ( Input.GetKeyDown( KeyCode.Space ) && simulate == false)
        {
            simulate = true;
            v3CurrentVelocity = v3InitialVelocity;
            transform.position = transform.position + Camera.main.transform.forward * zdisplacement * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.R)) { 
            simulate = false;
            transform.position = Vector3.zero; //shorthand for (0, 0, 0)
           
        }
    }
}



