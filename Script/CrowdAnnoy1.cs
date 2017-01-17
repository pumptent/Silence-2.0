using UnityEngine;
using System.Collections;

public class CrowdAnnoy1 : MonoBehaviour {

	//public Color rcolor = new Color (1, 0, 0);
	//public Renderer rend;
	//public Renderer rend2;
	private int N1;

    public static float N3;
    private float coolDown; 

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

        coolDown -= Time.deltaTime;
        AudioSource sound = Player.GetComponent<AudioOnoff> ().sound;

		if (Input.GetKeyDown ("a") && coolDown <= 0f) {
			int N2 = AudioOnoff.times;// the timer count
			if (Anger1 == N2) {
                //set color change
                N3 = Anger1;
                coolDown = 10f;
				

				Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

				//transform.Rotate (0, 40, 0);


			}

			if (Anger1 == 10 && sound.isPlaying) {


				sound.Stop ();
				shush.Play ();


			}
		}

        if (coolDown <= 0f)
        {
            N3 = 0;
        }

    }
		}

