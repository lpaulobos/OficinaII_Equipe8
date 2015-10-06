using UnityEngine;
using System.Collections;
	
public class minuteBehaviour : MonoBehaviour {
		
		
	Sprite[] sprites;
	private SpriteRenderer sr;
	float tempo = 0.15f;
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
			
		if (countTime <= 0 && rodando && !GameObject.Find("hour").GetComponent<hourBehaviour>().rodando) {
			countImage += 1;
			if (countImage > 59) {countImage = 0;}
			sr.sprite = sprites [countImage];
			countTime = tempo;
		}
			
		if (Input.GetButtonDown ("Fire1") && (countImage >= 24 && countImage <= 34) && !GameObject.Find("hour").GetComponent<hourBehaviour>().rodando) {
			
			Debug.Log ("Ganhou");
			rodando = false;
			Application.LoadLevel("Fase3");
		}
	}
}