using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CustomLerp[] i = FindObjectsOfType<CustomLerp>();

        foreach(CustomLerp a in i)
        {
            // find closest lerper
        }

        //closest lerper.LerpButton();


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(ray,out hit))
            {
                //we hit something!

                if(hit.transform.gameObject.TryGetComponent(out CustomLerp lerper))
                {
                    lerper.LerpButton();
                }

            }
        }
    }
}
