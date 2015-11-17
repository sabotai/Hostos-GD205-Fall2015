using UnityEngine;
using System.Collections;

public class BabyScript : MonoBehaviour {

	Animator babyAnim;

	int currentAnim;

	// Use this for initialization
	void Start () {
		babyAnim = GetComponent<Animator> ();

		if (babyAnim == null) {
			Debug.Log ("no animator found");
		} else {
			Debug.Log ("lez do dis");
		}

		currentAnim = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			currentAnim = 1;
		} else {
			currentAnim = 0;
		}
		babyAnim.SetInteger("Action", currentAnim);
	}
}
