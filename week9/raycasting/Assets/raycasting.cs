using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour {
	public GameObject mySphere; 

	void Update () {
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition); 
		Debug.DrawRay (myRay.origin, myRay.direction * 100f, Color.yellow); 
	
		RaycastHit myRayHit = new RaycastHit (); 

		//if my raycast hits something 
		if (Physics.Raycast (myRay, out myRayHit, 1000f)) {
			Debug.Log ("I hit something");

			mySphere.transform.position = myRayHit.point;

			if (Input.GetMouseButtonDown (0)) {
				Instantiate (mySphere, myRayHit.point, Quaternion.Euler (0f, 0f, 0f));
			}	
		} else {
			Debug.Log ("not hitting anything"); 
		}
	}

}
