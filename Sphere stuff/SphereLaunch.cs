using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;
using System;

public class SphereLaunch : MonoBehaviour
{

    public Rigidbody Sphere;
    public Transform Player;

    public float h =25;
    public float gravity = -18;

    // Start is called before the first frame update
    void Start()
    {
        Sphere.useGravity = false;
    }
    // Update is called once per frame
    private void Update()
    {
      
        if (Input.GetKeyDown (KeyCode.Space))
        {
            Launch();
        } 
        }

    private static void LaunhButton()
    { }


    void Launch()
{
    Physics.gravity = Vector3.up * gravity;
    Sphere.useGravity = true;
    Sphere.velocity = CalculateLaunchVelocity ();
        print(CalculateLaunchVelocity());
}
    Vector3 CalculateLaunchVelocity()
    {
        float displacementY = Player.position.y - Sphere.position.y;
        Vector3 displacementXZ = new Vector3(Player.position.x - Sphere.position.x, 0, Player.position.z - Sphere.position.z);
        float time = Mathf.Sqrt(-2*h/gravity) + Mathf.Sqrt(2*(displacementY - h)/gravity);
        Vector3 velocityY = Vector3.up * Mathf.Sqrt (-2 * gravity * h);
        Vector3 velocityXZ = displacementXZ / time;
    return velocityXZ + velocityY * -Mathf.Sign(gravity);
}
}