using UnityEngine;
using System.Collections;

public class CrowdAnnoy3 : MonoBehaviour {

    //public Color rcolor = new Color (1, 0, 0);
    //public Renderer rend;
    //public Renderer rend2;
    private int N1;
    public static float N3;
    private float coolDown;
	public GameObject Player;
	public static int Anger3;
	public AudioSource shush;
	public Color originalColor ;
	//public float yRotate = 0f;

	//public AudioSource shut;

	// Use this for initialization
	void Start () {
		


		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger3 = Anger3 + N1;

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
			if (Anger3 == N2) {
                //set color change
                N3 = Anger3;
                coolDown = 10f;

                Renderer rend = GetComponent<Renderer> ();
				rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

			
				transform.Rotate (0, 275, 0);

			}
		


			if (Anger3 == 10 && sound.isPlaying) {

				sound.Stop ();
				shush.Play ();

			}
		}


		if (Input.GetKeyDown ("s") && Anger3 == N2){

			//transform.Rotate(0,-85,0);
			Renderer rend = GetComponent<Renderer> ();
			rend.material.color = originalColor;

			transform.Rotate (0,85,0);
			
		}

        if (coolDown <= 0f)
        {
            N3 = 0;
        }

    }
		}

