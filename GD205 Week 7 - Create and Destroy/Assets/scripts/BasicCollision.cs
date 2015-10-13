using UnityEngine;
using System.Collections;

public class BasicCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision myCol) {
		Debug.Log("Collision with " + myCol.gameObject);
    }
}
