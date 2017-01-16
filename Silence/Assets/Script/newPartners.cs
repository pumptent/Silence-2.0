using UnityEngine;
using System.Collections;

public class newPartners : MonoBehaviour {


	public static int times;
	public AudioSource sound;
	public AudioSource partnerSound;

	// Use this for initialization
	void Start () {
		partnerSound.Play ();
	}

	// Update is called once per frame
	void Update () {

		GameObject Player = GameObject.Find ("Player");
		AudioSource sound = Player.GetComponent<AudioOnoff> ().sound;

		if (Input.GetKeyDown ("a")) {

			sound.Play ();
			partnerSound.Stop ();


			times = Random.Range (1, 16);

		}

		if (Input.GetKeyDown ("s")) {

			sound.Stop ();
			partnerSound.Play ();
		}

	}


}