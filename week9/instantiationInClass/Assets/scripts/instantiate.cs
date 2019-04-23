using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour {
	public GameObject prefabA; 
	public GameObject prefabB; 

	int count = 0; //how many game objects we are creating

	// Update is called once per frame
	void Update () {
		float r = Random.Range (0f, 100f); 

		if (count < 50) {
			if (r < 50f) {
				// generate object A
				GameObject newClone = (GameObject)Instantiate
					(prefabA, new Vector3(Random.Range(-5f, 5f),
						Random.Range(-5f, 5f),Random.Range(-5f, 5f)), 
						Quaternion.Euler (new Vector3(Random.Range (0f, 360f)
							,Random.Range (0f, 360f), Random.Range (0f, 360f)))); 

				newClone.transform.localScale = Vector3.one * Random.Range (0f, 1f);
			} else {
				//generate obejct B
				GameObject newClone2 = (GameObject)Instantiate
					(prefabB, new Vector3(Random.Range(-5f, 5f),
						Random.Range(-5f, 5f),Random.Range(-5f, 5f)), 
						Quaternion.Euler (new Vector3(Random.Range (0f, 360f)
							,Random.Range (0f, 360f), Random.Range (0f, 360f)))); 
				newClone2.GetComponent<Renderer> ().material.color = Random.ColorHSV (); 
					
			}
			count++; 
		} 	
	}
}
