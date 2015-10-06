using UnityEngine;
using System.Collections;

public class BusBehaviour : MonoBehaviour {
	private float randomic;

	void Start()
	{

		this.gameObject.name = this.GetComponent<SpriteRenderer> ().sprite.name;
		this.gameObject.rigidbody2D.gravityScale = 0f;
		this.gameObject.collider2D.isTrigger = true;

		switch (this.gameObject.name) {
			case "GreenBus":
				this.gameObject.tag = "Idoso";
				break;
			case "BlueBus":
				this.gameObject.tag = "Cadeirante";
				break;
			case "YellowBus":
				this.gameObject.tag = "Estudante";
				break;
		}


		randomic = Random.Range (0.1f, 0.35f);
	}
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (randomic, 0, 0);
		if (this.transform.position.x >= 12.5f) {
			Destroy(this.gameObject);
		}
	}
}
