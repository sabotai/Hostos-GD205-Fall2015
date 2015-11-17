using UnityEngine;
using System.Collections;

public class AnimationControl : MonoBehaviour {

	Animator myAnimator;	
	bool doAnim;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent <Animator> ();
		if (myAnimator == null) {
			Debug.Log ("no animator component found");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)){
			doAnim = !doAnim;
			//myAnimator.SetInteger ("Simple", 1);
			Debug.Log ("animSwitch");
		}
		
		myAnimator.SetBool ("flipAnim", doAnim);

	}
}
