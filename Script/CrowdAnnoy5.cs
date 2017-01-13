using UnityEngine;
using System.Collections;

public class CrowdAnnoy5 : MonoBehaviour {

	//public Color rcolor = new Color (1, 0, 0);
	//public Renderer rend;
	//public Renderer rend2;
	private int N1;
	public GameObject Player;
	public static int Anger5;
	public AudioSource shush;

	//public AudioSource shut;
	// Use this for initialization
	void Start () {

		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger5 = Anger5 + N1;

		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("a")) {
			int N2 = AudioOnoff.times;// the timer count
			if (Anger5 == N2) {
				//set color change
				
				Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

			}

			if (Anger5 == 10) {

				shush.Play ();

				//shut = AudioOnoff.sound.Stop();
			}

		}
	}
}

