﻿using UnityEngine;
using System.Collections;

public class CrowdAnnoy1 : MonoBehaviour {

	//public Color rcolor = new Color (1, 0, 0);
	//public Renderer rend;
	//public Renderer rend2;
	private int N1;
	public GameObject Player;
	public static int Anger1;
	public AudioSource shush;

	//public AudioSource shut;

	// Use this for initialization
	void Start () {
		
		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger1 = Anger1 + N1;

		}

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("a")) {
			int N2 = AudioOnoff.times;// the timer count
			if (Anger1 == N2) {
				//set color change
				
				Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

			}

			if (Anger1 == 10) {

				shush.Play ();

				//shut = AudioOnoff.sound.Stop();

			}
		}
	}
}
