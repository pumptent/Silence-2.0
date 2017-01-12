using UnityEngine;
using System.Collections;

public class AngerTotals : MonoBehaviour {

	public int meter;

	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {

		int Total = CrowdAnnoy.Anger + CrowdAnnoy1.Anger1 + CrowdAnnoy2.Anger2 + CrowdAnnoy3.Anger3 + CrowdAnnoy4.Anger4 + CrowdAnnoy5.Anger5;


	}
}
