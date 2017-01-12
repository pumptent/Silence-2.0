using UnityEngine;
using System.Collections;

public class CrowdAnnoy : MonoBehaviour {

	private int N1;
	//public GameObject P1;
	public static int Anger;
	public AudioSource shush;

	//public AudioSource shut;


	// Use this for initialization
	void Start () {
		


		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger = Anger + N1;

		}

	}

	// Update is called once per frame
	void Update () {
		
		int N2 = AudioOnoff.times;// the timer count
		if (Anger == N2) {
			//set color change
		

			Renderer rend = GetComponent<Renderer> ();
			//rend.material.shader = Shader.Find ("Specular");
			rend.material.SetColor ("_Color", Color.red);


		}
			

		if (Anger == 10) {

			shush.Play ();


			//shut = AudioOnoff.sound.Stop();
			}


	}
		}

