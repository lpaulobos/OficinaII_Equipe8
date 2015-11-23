using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Detecter : MonoBehaviour {
	
	public Text tx;
	public Sprite card;
	
	void Start()
	{
		tx = GameObject.Find ("Passe").GetComponent<Text> ();
		for(int i = 0; i <= PlayerPrefs.GetInt("lifes"); i++ )
		{
			GameObject card = Instantiate(card, new Vector2 (-1.15f + 1.4f * i,-2.21f),Quaternion.identity) as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D colider)
	{
		if (colider.gameObject.name == "rioCard") {
			PlayerPrefs.GetInt("Pass");		
		}
	}
	void Verifier()
	{
		
	}
}
