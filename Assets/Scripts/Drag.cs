using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {

	void OnMouseDrag()
	{
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		curPosition.z = 0;
		this.transform.position = curPosition;
	}
}
