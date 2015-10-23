using UnityEngine;
using System.Collections;

public class hourBehaviour : MonoBehaviour {


	Sprite[] sprites;
	private SpriteRenderer sr;
	float tempo = 0.5f;
	public float countTime;
	public int countImage = 0;

	// Use this for initialization
	void Start () {
		countImage = 5;
		countTime = tempo;
		sr = this.gameObject.GetComponent<SpriteRenderer>(); 
		sprites = Resources.LoadAll<Sprite> ("Imagens/Level1/JPG");
	}
	
	// Update is called once per frame
	void Update () {
		sr.sprite = sprites[countImage];
	}
}
