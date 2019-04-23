using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCUBES : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if i press my left arrow key, rotate left 
		if (Input.GetKey("f")) {
			transform.Rotate (0, 1f, 0); 
		}
		if (Input.GetKey ("h")) {
			transform.Rotate (0, -1f, 0); 
		}
		if (Input.GetKey ("t")) {
			transform.Rotate (1f, 0, 1f); 
		}
		if (Input.GetKey ("g")) {
			transform.Rotate (-1f, 0, -1f); 
		}

	}
}
