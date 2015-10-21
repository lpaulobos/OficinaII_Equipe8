using UnityEngine;
using System.Collections;

public class bgBehaviour : MonoBehaviour {

	
	// Update is called once per frame
	void FixedUpdate () {
		if(this.gameObject.name == "cenario"){
			this.transform.position += new Vector3 (-0.1f,0,0);
		}
		
	}
}
