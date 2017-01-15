using UnityEngine;
using System.Collections;

public class CrowdAnnoy3 : MonoBehaviour {

	//public Color rcolor = new Color (1, 0, 0);
	//public Renderer rend;
	//public Renderer rend2;
	private int N1;
	public GameObject Player;
	public static int Anger3;
	public AudioSource shush;
	//public float yRotate = 0f;

	//public AudioSource shut;

	// Use this for initialization
	void Start () {
		


		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger3 = Anger3 + N1;

		}


	}

	// Update is called once per frame
	void Update () {


		AudioSource sound = Player.GetComponent<AudioOnoff> ().sound;
		int N2 = AudioOnoff.times;// the timer count

		if (Input.GetKeyDown ("a")) {
			if (Anger3 == N2) {
				//set color change
				

				Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

			
				transform.Rotate (0, -85, 0);

			}
			if (Anger3 == 10 && sound.isPlaying) {

				sound.Stop ();
				shush.Play ();



			}

		}


		//if (Input.GetKeyDown ("s") && Anger3 == N2){

			//transform.Rotate(0,-85,0);

			//transform.rotation = Quaternion.identity;

		//}

		}
		}

