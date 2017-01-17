using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    //private float seconds = 0.0f;
    //private float minutes = 0.0f;
    float countDown = 30;
    Text testIndicator;

	// Use this for initialization
	void Start () {
        testIndicator = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        countDown -= Time.deltaTime;

        if (countDown >= 0)
        {
            testIndicator.text = "Time Left = 0:" + countDown;
        }

        else if (countDown < 0)
        {
            testIndicator.text = "Game Over!";
        }

		}
	}

