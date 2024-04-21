using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasingFunction : MonoBehaviour
{
    //start where you ease from
    public float start;
    //target of where you ease to
    public float end;
    //duration/time
    public float duration;


    // Start is called before the first frame update
    void Start()
    {
        easeInOutSine(start, end, duration);
        Debug.Log("ran");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float easeInOutSine(float start, float end, float duration)
    {
        duration /= .5f;
        end -= start;
        if(duration < 1) return end * 0.5f * duration * duration + start;
        duration--;
        Debug.Log("Start" + start);
        return -end * 0.5f * (duration * (duration - 2) -1) + start;
       
    }
}
