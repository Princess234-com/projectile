using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    // This script makes objects glow when clicked on.So it glows while lerping
   //https://www.youtube.com/watch?v=GbXC1C2nBNA
        MeshRenderer MR;
    // Start is called before the first frame update
    void Start()
    {
        MR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MR.material.EnableKeyword("_EMISSION");
        }
    }
}
