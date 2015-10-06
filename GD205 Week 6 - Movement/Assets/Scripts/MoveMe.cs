using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour {

	public GameObject elevator;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 is a point in 3D space.  Vector3(XAxis, YAxis, ZAxis)
		//GetComponent<Transform>().position += new Vector3 ( 0f, 0f, 0.1f );
		//GetComponent<Transform>().position = GetComponent<Transform>().position + new Vector3 (0f,0f,0.1f);

		//lowercase transform is a shortcut for "GetComponent<Transform>()"
		//transform.position += new Vector3( 2f, 0f, -0.245f );
		Debug.Log(transform.position);

		transform.Translate ( new Vector3( 0f, .01f, 0f ) );
		//transform.Translate (elevator.transform.position);


	}
}
