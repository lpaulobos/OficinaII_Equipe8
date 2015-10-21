using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BusManager : MonoBehaviour {
	public Sprite[] busSprites;
	public GameObject[] bus;
	private int count = 0;
	public GameObject col;
	public List<GameObject> people = new List<GameObject>();

	void Start()
	{	
		people.Add(GameObject.Find("Estudante"));
		people.Add(GameObject.Find("Cadeirante"));
	}

	void InstantiateBus(int a)
	{	
		bus[a] = new GameObject();
		bus[a].transform.position = new Vector2 (-10, 0.5f);
		bus[a].AddComponent<SpriteRenderer> ();
		bus[a].AddComponent<BusBehaviour> ();
		bus[a].GetComponent<SpriteRenderer> ().sprite = busSprites [a];
		bus[a].AddComponent<BoxCollider2D>();
		bus[a].AddComponent<Rigidbody2D>();
	}
		
	IEnumerator busDelay (float _time) {
		yield return new WaitForSeconds(_time);
		InstantiateBus(Random.Range(0,3));
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		count++;

		if (count >= 120) {
			InstantiateBus (Random.Range (0, 2));
			count = 0;
		}
		if(people.Count <= 0)
		{
			Application.LoadLevel(5);
		}
		Debug.Log (people.Count);
	}
	void OnTriggerEnter2D(Collider2D colider)
	{
		col = colider.gameObject;
	}
}
