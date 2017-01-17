using UnityEngine;
using System.Collections;

public class CrowdAnnoy4 : MonoBehaviour {

	//public Color rcolor = new Color (1, 0, 0);
	//public Renderer rend;
	//public Renderer rend2;
	private int N1;
	public GameObject Player;
	public static int Anger4;
	public AudioSource shush;
	public Color originalColor ;


	//public AudioSource shut;

	// Use this for initialization
	void Start () {
		


		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger4 = Anger4 + N1;

		}

		Renderer rend = GetComponent<Renderer> ();
		originalColor = rend.material.color;


	}

	// Update is called once per frame
	void Update () {


		AudioSource sound = Player.GetComponent<AudioOnoff> ().sound;
		int N2 = AudioOnoff.times;// the timer count

		if (Input.GetKeyDown ("a")) {

			if (Anger4 == N2) {
				//set color change
				

				Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

				transform.Rotate (0, 80, 0);

			}
		

			if (Anger4 == 10 && sound.isPlaying) {

				sound.Stop ();
				shush.Play ();


			}
		}


		if (Input.GetKeyDown ("s") && Anger4 == N2){

			//transform.Rotate(0,-85,0);
			Renderer rend = GetComponent<Renderer> ();
			rend.material.color = originalColor;

			transform.Rotate (0, 280, 0);


		}
			

		}
		}

