using UnityEngine;
using System.Collections;

public class Convopartner : MonoBehaviour {


	public static int times;
	//public AudioClip s;
	public AudioSource sound;
	public AudioClip sound2;
	// Use this for initialization
	void Start () {

		sound = GetComponent<AudioSource> ();
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


		if (!sound.isPlaying) {
			sound.clip = sound2;
			sound.Play ();

		}


	}


}
