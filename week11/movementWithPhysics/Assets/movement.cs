using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public GameObject cube; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if (Input.GetKey (KeyCode.Space)) {
			cube.GetComponent<Rigidbody> ()
				.AddForce (cube.transform.forward * 10f);
		}
		if (Input.GetKey (KeyCode.Return)) {
			cube.GetComponent<Rigidbody> ()
				.AddForce (cube.transform.forward * -10f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			cube.GetComponent<Transform> ().Rotate (0f, -5f, 0f);
		}else if (Input.GetKey (KeyCode.RightArrow)) {
			cube.GetComponent<Transform> ().Rotate (0f, 5f, 0f);
		}
	}
}
