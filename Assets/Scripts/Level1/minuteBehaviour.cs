using UnityEngine;
using System.Collections;
	
public class minuteBehaviour : MonoBehaviour {
		
		
	Sprite[] sprites;
	private SpriteRenderer sr;
	public SpriteRenderer hr;
	float tempo = 0.25f;
	public float countTime;
	public int countImage = 0;
	public int hourCountImage = 5;
	bool rodando = true;

	// Use this for initialization
	void Start () {
		countTime = tempo;
		sr = this.gameObject.GetComponent<SpriteRenderer>();
		hr = GameObject.Find("hour").GetComponent<SpriteRenderer>();
		sprites = Resources.LoadAll<Sprite> ("Imagens/Level1/JPG");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(rodando)
		{
			countTime -= Time.deltaTime;
				
			if (countTime <= 0) 
			{
				countImage += 5;
				if (countImage > 59)
				{
					countImage = 0;
					hourCountImage += 1;
					hr.sprite = sprites[hourCountImage];
				}
				sr.sprite = sprites [countImage];
				hr.sprite = sprites [hourCountImage];
				countTime = tempo;
			}
				
			if (Input.GetButtonDown ("Fire1") && (countImage >= 24 && countImage <= 34)) {
				Application.LoadLevel("transicao");
			}
		}
		if(Input.GetMouseButton(0))
		{
			clickou();
		}
	}
	void clickou()
	{
		PlayerPrefs.SetInt("points",0);
		rodando = false;
		int pts = (hourCountImage * 100) + countImage;
		if(pts >= 615 && pts <= 640)
		{
			PlayerPrefs.SetInt("points", PlayerPrefs.GetInt("points") + 150);
		}
		else if(pts >= 530 && pts <= 615 || pts >= 640 && pts <= 700)
		{
			PlayerPrefs.SetInt("points", PlayerPrefs.GetInt("points") + 75);
		}
		Debug.Log(PlayerPrefs.GetInt("points"));
	}
}