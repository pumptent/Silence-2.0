using UnityEngine;
using System.Collections;

public class CrowdAnnoy : MonoBehaviour {

	private int N1;
    public static float N3;
    private float coolDown;

	public GameObject Player;
	public static int Anger;
	public AudioSource shush;

	//public AudioSource shut;


	// Use this for initialization
	void Start () {


        N3 = 0;

		N1 = Random.Range (0, 11);
		//P1 = N1;

		if (N1 > 0) {

			Anger = Anger + N1;

		}

	}

	// Update is called once per frame
	void Update () {

        coolDown -= Time.deltaTime;

		AudioSource sound = Player.GetComponent<AudioOnoff> ().sound;

		if (Input.GetKeyDown ("a") && coolDown <= 0f) {
			int N2 = AudioOnoff.times;// the timer count
			if (Anger == N2) {
                //set color change
                N3 = Anger;
                coolDown = 10f;

                Renderer rend = GetComponent<Renderer> ();
				//rend.material.shader = Shader.Find ("Specular");
				rend.material.SetColor ("_Color", Color.red);

				//transform.Rotate (0, 80, 0);

	        }


			

		if (Anger == 10 && sound.isPlaying) {

				sound.Stop ();

				shush.Play ();

		}

        if (coolDown <= 0f)
            {
                N3 = 0;
            }
	}
  }

}

