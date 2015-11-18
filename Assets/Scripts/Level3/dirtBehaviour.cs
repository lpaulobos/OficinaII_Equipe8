using UnityEngine;
using System.Collections;

public class dirtBehaviour : MonoBehaviour {

	public int numBrushes; 
	public int numBrushesOn;

	void Update()
	{
		if (numBrushesOn >= numBrushes) {
			Destroy(this.gameObject);
			PlayerPrefs.SetInt("points",PlayerPrefs.GetInt("points") + 25);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Escova")
		{
			this.numBrushesOn += 1;
			Debug.Log("Colliding");
		}
	}

}
