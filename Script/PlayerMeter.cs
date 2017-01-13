using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMeter : MonoBehaviour {

    public int meter;

    //Text testIndicator;

	// Use this for initialization
	void Start () {
        //testIndicator = GetComponent<Text>();
	}
	 
	// Update is called once per frame
	void Update () {

        meter = AngerTotals.Total;

        if (meter <= 25)
        {
            testIndicator = "green";
        }
        else if (meter > 25 && meter <= 50)
        {
            testIndicator = "yellow";
        }
        else if (meter > 50 && meter <= 75)
        {
            testIndicator = "orange";
        }
        else if (meter > 75 && meter <= 100)
        {
            testIndicator = "red";
        }
        else if (meter > 100)
        {
            testIndicator = "dead";
            //Application.LoadLevel(Application.loadedLevel);
        }
    }
}
