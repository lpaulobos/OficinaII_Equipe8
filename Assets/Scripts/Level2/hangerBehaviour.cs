using UnityEngine;
using System.Collections;

public class hangerBehaviour : MonoBehaviour {

	public GameObject correctly;
	public bool hasCorrectly;
	// Use this for initialization
	void Start () {
		hasCorrectly = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject == correctly && !hasCorrectly) {
			col.gameObject.transform.position = new Vector2(this.transform.position.x,
			                                                this.transform.position.y - (col.gameObject.transform.localScale.y + 0.5f));
			hasCorrectly = true;
/*			GameObject.Find("Manager").GetComponent<clothSelect>().colider = null;
			GameObject.Find("Manager").transform.position = new Vector3 (-6,0,0);
		} else if (col.gameObject != correctly && !hasCorrectly) {
			Debug.Log ("Errou!");
		}
	}/*/
}
