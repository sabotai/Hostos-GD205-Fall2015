using UnityEngine;
using System.Collections;

public class HumanState : MonoBehaviour {
	
	Animator myAnimator;	
	public int doAnim;
	
	// Use this for initialization
	void Start () {
		myAnimator = GetComponent <Animator> ();
		if (myAnimator == null) {
			Debug.Log ("no animator component found");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			doAnim = 1;
			//myAnimator.SetInteger ("Simple", 1);
			Debug.Log ("animSwitch");
		} else {
			doAnim = 0;
		}
		
		myAnimator.SetInteger ("Action", doAnim);
		
	}
}
