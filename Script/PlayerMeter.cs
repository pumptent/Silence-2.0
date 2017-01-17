using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMeter : MonoBehaviour
{

    private float meter;

    Text testIndicator;

    // Use this for initialization
    void Start()
    {
        testIndicator = GetComponent<Text>();
        meter = 0;
    }

    // Update is called once per frame
    void Update()
    {

        meter = CrowdAnnoy.N3 + CrowdAnnoy1.N3 + CrowdAnnoy2.N3 + CrowdAnnoy3.N3 + CrowdAnnoy4.N3 + CrowdAnnoy5.N3;

        if (meter <= 5)
        {
            //testIndicator.text = "green: " + meter;
            testIndicator.text = "[ ......................... ]";
        }
        else if (meter > 5 && meter <= 10)
        {
            //testIndicator.text = "yellow" + meter;
            testIndicator.text = "[ IIIII.................... ]";
        }
        else if (meter > 10 && meter <= 15)
        {
            testIndicator.text = "orange" + meter;
            testIndicator.text = "[ IIIIIIIIII............... ]";
        }
        else if (meter > 15 && meter <= 20)
        {
            testIndicator.text = "red" + meter;
            testIndicator.text = "[ IIIIIIIIIIIIIII.......... ]";
        }
        else if (meter > 20)
        {
            testIndicator.text = "dead" + meter;
            testIndicator.text = "[ IIIIIIIIIIIIIIIIIIII..... ]";
            //Application.LoadLevel(Application.loadedLevel);
        }
    }
}