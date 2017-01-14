using UnityEngine;
using System.Collections;

public class AudioOnoff : MonoBehaviour {


	public static int times;
	public AudioSource sound;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

			if (Input.GetKeyDown ("a")) {

				 sound.Play ();

				times = Random.Range (1, 16);

			}

		if (Input.GetKeyDown ("s")) {

			sound.Stop ();


		}

		}
	

}
