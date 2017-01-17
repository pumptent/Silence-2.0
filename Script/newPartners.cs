using UnityEngine;
using System.Collections;

public class newPartners : MonoBehaviour {


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



		}

		if (Input.GetKeyDown ("s")) {

			sound.Stop ();
			partnerSound.Play ();
		}
			
	}


}