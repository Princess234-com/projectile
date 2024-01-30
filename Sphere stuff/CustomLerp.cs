using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomLerp : MonoBehaviour

{
    public GameObject sphere;
    private float startPos;
    //End
    private float endPos;
    //Distance
    public float xpos;
    // Use this for initialization

    bool lerping;
    float lerpFloat; 
    // Here are some of the various easing function
    public enum eases
    {
        QuadraticIn, QuadraticOut, QuadraticInOut,CubicIn, CubicOut, CubicInOut, QuarticIn, QuarticOut, QuarticInOut,
        QuinticIn, QuinticOut, QuinticInOut, SinusoidalIn, SinusoidalOut, SinusoidalInOut, ExponentialIn, ExponentialOut, ExponentialInOut,
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
            else if (ease == eases.QuadraticInOut)
            {
                perc = Easings.Quadratic.InOut(time);
            }
            if (ease == eases.CubicIn)
            {
                perc = Easings.Cubic.In(time);
            }
            else if (ease == eases.CubicOut)
            {
                perc = Easings.Cubic.Out(time);
            }
            else if (ease == eases.CubicInOut)
            {
                perc = Easings.Cubic.InOut(time);
            }
            if (ease == eases.QuarticIn)
            {
                perc = Easings.Quartic.In(time);
            }
            else if (ease == eases.QuarticOut)
            {
                perc = Easings.Quartic.Out(time);
            }
            else if (ease == eases.QuarticInOut)
            {
                perc = Easings.Quartic.In(time);
            }
            if  (ease == eases.QuinticIn)
            {
                perc = Easings.Quintic.In(time);   
            }
             else if (ease == eases.QuinticOut)
            {
                perc = Easings.Quintic.Out(time);
            }
              if (ease == eases.QuinticInOut)
            {
                perc = Easings.Quintic.InOut(time);
            }
             if (ease == eases.SinusoidalIn)
            {
                perc = Easings.Sinusoidal.In(time);
            }
             else if (ease == eases.SinusoidalOut)
            {
                perc = Easings.Sinusoidal.Out(time);
            }
              if (ease == eases.SinusoidalInOut)
            {
                perc = Easings.Sinusoidal.InOut(time);
            }
             if (ease == eases.ExponentialIn)
            {
                perc = Easings.Exponential.In(time);
            }

            else if (ease == eases.ExponentialOut)
            {
                perc = Easings.Exponential.Out(time);
            }

              if (ease == eases.ExponentialInOut)
            {
                perc = Easings.Exponential.InOut(time);
            }

            

            lerpFloat = Lerp(0, 10, perc);
            time += Time.deltaTime;
            yield return null;
        }
        lerping = false;
    }
    private void Update()
    {
        //we are using makes to lerp it upwards ie in the y axis
        transform.position = new Vector3(transform.position.x, lerpFloat, transform.position.z);
        startPos = sphere.transform.position.y;
        endPos = sphere.transform.position.y + 1 * distance;
        xpos = sphere.transform.position.x;
        //Used to correct "Should not be capturing when there is a hotcontrol"
        new Vector2(sphere.transform.position.x * Time.deltaTime, sphere.transform.position.y * Time.deltaTime);
    }

    //Start
    void Start()
{
        //sphere = GameObject.FindWithTag("sphere 2");
    }

}