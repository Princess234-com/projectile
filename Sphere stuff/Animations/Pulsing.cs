using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsing : MonoBehaviour
{
    //This makes the sphere pulse when mouse pointer in on it
    //https://www.bing.com/ck/a?!&&p=e1a566a69b3f2223JmltdHM9MTY2OTc2NjQwMCZpZ3VpZD0wYTk2MzRlYi1kZmMxLTY5Y2YtMmQzNC0yNmRkZGVhMjY4YzImaW5zaWQ9NTE4NA&ptn=3&hsh=3&fclid=0a9634eb-dfc1-69cf-2d34-26dddea268c2&psq=how+to+use+object+details+by+just+hovering+your+mouseon+it+in+unity&u=a1aHR0cHM6Ly93d3cueW91dHViZS5jb20vd2F0Y2g_dj0wcWx4cm5EXzhEUQ&ntb=1
    // Start is called before the first frame update
    private bool coroutineAllowed;
    void Start()
    {
        coroutineAllowed = true; 
    }

    private void OnMouseOver()
    {
        if (coroutineAllowed)
        {
            StartCoroutine("StartPulsing");
        }
    }
    // Update is called once per frame
    private IEnumerator StartPulsing()
    {
        coroutineAllowed = false;

        for (float i =0f;  i <= 1f; i += 0.1f)
        {
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                 (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                  (Mathf.Lerp(transform.localScale.z, transform.localScale.z + 0.025f, Mathf.SmoothStep(0f, 1f, i)))
                  );
            yield return new WaitForSeconds(0.015f);
        }

        coroutineAllowed = true;
    }
    void Update()
    {
        
    }
}
