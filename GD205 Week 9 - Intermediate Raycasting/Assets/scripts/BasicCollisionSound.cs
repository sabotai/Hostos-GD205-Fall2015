using UnityEngine;
using System.Collections;

public class BasicCollisionSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//everytime a collision occurs, this function will be called and the collision information will be passed into 
	void OnCollisionEnter(Collision myCol) {
		//within the collision object created, called myCol .gameObject is a way of accessing the object collided with
		GetComponent<AudioSource>().Play();
    }
}
