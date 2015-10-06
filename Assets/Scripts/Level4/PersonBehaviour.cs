using UnityEngine;
using System.Collections;

public class PersonBehaviour : MonoBehaviour {

	void OnMouseDown()
	{
		if (GameObject.Find ("Manager").GetComponent<BusManager> ().col != null) {
			if (this.gameObject.name == GameObject.Find ("Manager").GetComponent<BusManager> ().col.gameObject.tag) {
				Destroy (this.gameObject);
				GameObject.Find ("Manager").GetComponent<BusManager> ().people.Remove(GameObject.Find (this.gameObject.name));
			}
		}
	}
}
