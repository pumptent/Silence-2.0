using UnityEngine;
using System.Collections;

public class LighteningController : MonoBehaviour {

    Color lightColor;
    public float nextLightening = 0f;
    bool isLightening = false;
    public float lighteningWave = 0f;
    Light myLight;

	// Use this for initialization
	void Start () {
        myLight = GetComponent<Light>();
        lightColor = myLight.color;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLightening)
        {
            nextLightening -= Time.deltaTime;
            if (nextLightening <= 0)
            {

                isLightening = true;
                nextLightening = Random.Range(1f, 2f);
            }

        }

        else {

            lighteningWave += Time.deltaTime;
            myLight.color = lightColor * Mathf.Cos(lighteningWave * 200f);
            if (lighteningWave > 0.3f) {

                lighteningWave = 0f;
                isLightening = false;
                myLight.color = lightColor * 0f;
            }
        }
	}
}
