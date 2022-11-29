using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//from https://thiscodedoesthis.com/how-to-make-an-object-orbit-another-in-unity/#:~:text=Would%20you%20like%20to%20make%20one%20object%20orbit,that%20is%20revolving%20around%20another%20object%2C%20or%20point.
public class rotate : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private float degreesPerSecond = 45;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.forward, degreesPerSecond * Time.deltaTime);
    }
}
