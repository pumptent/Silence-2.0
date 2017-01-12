using UnityEngine;
using System.Collections;

public class CrowdAnnoy3 : MonoBehaviour {

	//public Color rcolor = new Color (1, 0, 0);
	//public Renderer rend;
	//public Renderer rend2;
	private int N1;
	//public GameObject P1;
	public static int Anger3;
	public AudioSource shush;

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
		if (Input.GetKeyDown ("a")) {
			int N2 = AudioOnoff.times;// the timer count
			if (Anger3 == N2) {
				//set color change
				

				Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

			}
			if (Anger3 == 10) {

				shush.Play ();

				//shut = AudioOnoff.sound.Stop();

			}

		}
		}
		}

