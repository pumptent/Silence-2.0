using UnityEngine;
using System.Collections;

public class CrowdAnnoy5 : MonoBehaviour {

	//public Color rcolor = new Color (1, 0, 0);
	//public Renderer rend;
	//public Renderer rend2;
	private int N1;
    public static float N3;
    private float coolDown;

	public GameObject Player;
	public static int Anger5;
	public AudioSource shush;
	public Color originalColor ;
	//public AudioSource shut;
	// Use this for initialization
	void Start () {
		


		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger5 = Anger5 + N1;

		}

		Renderer rend = GetComponent<Renderer> ();
		originalColor = rend.material.color;


	}

	// Update is called once per frame
	void Update () {

        coolDown -= Time.deltaTime;
        AudioSource sound = Player.GetComponent<AudioOnoff> ().sound;
		int N2 = AudioOnoff.times;// the timer count

		if (Input.GetKeyDown ("a") && coolDown <= 0f) {
			

			if (Anger5 == N2) {
                //set color change
                N3 = Anger5;
                coolDown = 10f;

				Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);



			}

			if (Anger5 == 10 && sound.isPlaying) {

				sound.Stop ();
				shush.Play ();

				//shut = AudioOnoff.sound.Stop();
			}

		}


		if (Input.GetKeyDown ("s") && Anger5 == N2){

			//transform.Rotate(0,-85,0);
			Renderer rend = GetComponent<Renderer> ();
			rend.material.color = originalColor;
		}

        if (coolDown <= 0f)
        {
            N3 = 0;
        }
    }
		}

