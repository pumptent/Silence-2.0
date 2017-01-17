using UnityEngine;
using System.Collections;

public class Partners : MonoBehaviour {


	public static int times;
	public AudioSource sound;
	public AudioSource partnerSound;
	public int AssignNum;
	public Color originalColor ;

	// Use this for initialization
	void Start () {
		partnerSound.Play ();

		AssignNum = Random.Range (0, 11);

		Renderer rend = GetComponent<Renderer> ();
		originalColor = rend.material.color;
	}

	// Update is called once per frame
	void Update ()
	{

		GameObject Player = GameObject.Find ("Player");
		AudioSource sound = Player.GetComponent<AudioOnoff> ().sound;
		int N2 = AudioOnoff.times;

		if (!Input.GetKeyDown ("a") && AssignNum == N2) {

			Renderer rend = GetComponent<Renderer> ();
			//rend.material.shader = Shader.Find ("Specular");
			rend.material.SetColor ("_Color", Color.red); 

		}
		if (Input.GetKeyDown ("a")) {

			sound.Play ();
			partnerSound.Stop ();

			Renderer rend = GetComponent<Renderer> ();
			rend.material.color = originalColor;
			//times = Random.Range (1, 16);

		}

		if (Input.GetKeyDown ("s")) {

			sound.Stop ();
			partnerSound.Play ();
		}
			


	}
}