using UnityEngine;
using System.Collections;

public class CrowdAnnoy2 : MonoBehaviour {


	private int N1;
	public GameObject Player;
	public static int Anger2;
	public AudioSource shush;
	public float yRotate = 40f;
	public Color originalColor ;
	//public Transform target;

	//public void LookAt(Transform target, Vector3 worldUp = Vector3.up);

	//public AudioSource shut;

	// Use this for initialization
	void Start () {

		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger2 = Anger2 + N1;

		}

		Renderer rend = GetComponent<Renderer> ();
		originalColor = rend.material.color;
	

	}

	// Update is called once per frame
	void Update () {


	
		//transform.position = new Vector3 (0, 0, 0);
		AudioSource sound = Player.GetComponent<AudioOnoff> ().sound;
		int N2 = AudioOnoff.times;// the timer count


		if (Input.GetKeyDown ("a")) {

			if (Anger2 == N2) {
				//set color change

				Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

				//transform.LookAt (target);
				//Vector3 relativePos = target.position - transform.position;
				//Quaternion rotation = Quaternion.LookRotation(relativePos);
				//transform.rotation = rotation;


				//yRotate = 40;

				transform.Rotate (0, 40, 0);

				//Anger2 = 0;
			}

		

			if (Anger2 == 10 && sound.isPlaying) {

				sound.Stop ();
				shush.Play ();

	
			}
		}

		if (Input.GetKeyDown ("s") && Anger2 == N2) {

			Renderer rend = GetComponent<Renderer> ();
			rend.material.color = originalColor;

			transform.Rotate (0,320,0);
		}

		}
		}

