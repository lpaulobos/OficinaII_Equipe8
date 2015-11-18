using UnityEngine;
using System.Collections;

public class clothSelect : MonoBehaviour {

	private Sprite[] sprites;
	private SpriteRenderer cloth;
	public float time = 0.1f;
	private float countTime;
	private int countShirt = 0;
	public int rightAnswer;
	public int numSprites;
	string selected;

	// Use this for initialization
	void Start () {

		countTime = time;
		cloth = this.gameObject.GetComponent<SpriteRenderer>(); 

		selected = "selected";

		switch (this.gameObject.name) {
			case "shirt":
			sprites = Resources.LoadAll<Sprite> ("Imagens/Level2/Camisas");
			break;

			case "trousers":
			sprites = Resources.LoadAll<Sprite> ("Imagens/Level2/calças");
			break;

			case "tenis":
			sprites = Resources.LoadAll<Sprite>("Imagens/Level2/tenis");
			break;
		}
			
	
	}
	void OnMouseDrag()
	{
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		curPosition.z = 0;
		this.transform.position = curPosition;
		Debug.Log (curPosition);
	
	}
}
