using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{

    //private float seconds = 0.0f;
    //private float minutes = 0.0f;
    //private float hours = 0.0f;
    public Text timerText;
    private float times;
    //public static float t;
    // Use this for initialization
    void Start()
    {
        times = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        //int anger = AudioOnoff.
        //if(time == anger){

        float t = Time.time - times;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
        //}
    }
}


