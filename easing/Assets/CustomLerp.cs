using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomLerp : MonoBehaviour

{
    public GameObject Cube;
    private float startPos;
    //End
    private float endPos;
    //Distance
    public float xpos;
    // Use this for initialization

    bool lerping;
    float lerpFloat; 
    public enum eases
    {
        QuadraticIn, QuadraticOut, QuadraticInOut, QuadraticBezier, CubicIn, CubicOut, CubicInOut, QuarticIn, QuarticOut, QuarticInOut,
        QuinticIn, QuinticOut, QuinticInOut, SinusoidalIn, SinusoidalOut, SinusoidalInOut, ExponentialIn, ExponentialOut, ExponentialInOut,
        CircularIn, CircularOut, CircularInOut, ElasticIn, ElasticOut, ElasticInOut, BackIn, BackOut, BackInOut,
        BounceIn, BounceOut, BounceInOut,
    }
    public eases myEase;
    float z;
    private int distance;

    public void LerpButton()
    {
        if ( lerping == false )
        {
            StartCoroutine(LerpFloat(myEase));
        }
      
    }
    public static float Lerp(float startValue, float endValue, float p)
    {
        return (startValue + (endValue - startValue) * p);
    }
    IEnumerator LerpFloat( eases ease )
    {
        lerping = true;
        float time = 0;
        while (time < 1)
        {
            float perc = 0;
            if (ease == eases.QuadraticIn)
            {
                perc = Easings.Quadratic.In(time);
            }
            else if (ease == eases.QuadraticOut)
            {
                perc = Easings.Quadratic.Out(time);
            }
            if (ease == eases.QuadraticInOut)
            {
                perc = Easings.Quadratic.InOut(time);
            }
          
            lerpFloat = Lerp(0, 10, perc);
            time += Time.deltaTime;
            yield return null;
        }
        lerping = false;
    }
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, lerpFloat, transform.position.z);
        startPos = Cube.transform.position.y;
        endPos = Cube.transform.position.y + 1 * distance;
        xpos = Cube.transform.position.x;
       
    }

    //Start
    void Start()
{
        //Cube = GameObject.FindWithTag("Cube 2");
    }

}