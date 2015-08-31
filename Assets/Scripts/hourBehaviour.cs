using UnityEngine;
using System.Collections;

public class hourBehaviour : MonoBehaviour {


	Sprite[] sprites;
	private SpriteRenderer sr;
	float tempo = 0.5f;
	public float countTime;
	public int countImage = 0;
	public bool rodando = true;

	// Use this for initialization
	void Start () {
		countTime = tempo;
		sr = this.gameObject.GetComponent<SpriteRenderer>(); 
		sprites = Resources.LoadAll<Sprite> ("Imagens/Level1/JPG");
	}
	
	// Update is called once per frame
	void Update () {
		countTime -= Time.deltaTime;

		if (countTime <= 0 && rodando) {
			countImage += 1;
			if(countImage > 23){countImage = 0;}
			sr.sprite = sprites[countImage];
			countTime = tempo;

		}
		Debug.Log (countImage);

		if (Input.GetButtonDown ("Fire1") && (countImage >= 5 && countImage <= 7)) {

			rodando = false;
		}
	}
}
