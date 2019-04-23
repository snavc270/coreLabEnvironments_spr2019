using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimation : MonoBehaviour {
	Animator anim;
	int walk = Animator.StringToHash("walking"); //whatever you named you animations in your animator controller
	int idle = Animator.StringToHash("idle"); 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update () {
		//		transform.position = new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y-1f, Camera.main.transform.position.z+5f);  ; 
		//		transform.rotation = Quaternion.Euler (Camera.main.transform.transform.eulerAngles.x, Camera.main.transform.transform.eulerAngles.y, Camera.main.transform.transform.eulerAngles.z); 
		//		transform.position = new Vector3 (Camera.main.transform.position.x , Camera.main.transform.position-5f, Camera.main.transform.position.forward+5f); 

		if (Input.GetKey (KeyCode.RightArrow)) {
			//			transform.position += transform.right * .2f;  
			transform.Rotate(0f, -5f, 0f); 
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(0f, 5f, 0f);  
		} else if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position += transform.right * .2f;  
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position -= transform.right * .2f;  
		} 


		if (Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
			{
				anim.SetTrigger (walk);
			}
		} 

		if(Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow)){
			anim.SetTrigger (idle); 
		}
	}
}
