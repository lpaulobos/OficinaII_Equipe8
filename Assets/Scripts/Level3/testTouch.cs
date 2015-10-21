using UnityEngine;
using System.Collections;

public class testTouch : MonoBehaviour {
	
	public Vector2 fingerPos;
	public Ray realWorldPos;
	RaycastHit marcs;
	void Update()
	{
		if(Input.touchCount > 0){
		
			fingerPos = Input.GetTouch(0).position;
			Vector2 pos = fingerPos;
			realWorldPos = Camera.main.ScreenPointToRay(pos);
			//Vector3 albertinho = new Vector3(realWorldPos.x,realWorldPos.y,0);
			//transform.position = albertinho; 
			
			if(Physics.Raycast(realWorldPos, out marcs))
			{
				this.transform.position = new Vector3(marcs.point.x,marcs.point.y,0);
			}
		}
		
		
		if(!GameObject.FindGameObjectWithTag("Dirt"))
		{
			Application.LoadLevel("Fase4");
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Dirt")
		{
			if(GameObject.Find (col.gameObject.name).GetComponent<dirtBehaviour>().numBrushesOn < 
			   GameObject.Find (col.gameObject.name).GetComponent<dirtBehaviour>().numBrushes)
				GameObject.Find (col.gameObject.name).GetComponent<dirtBehaviour>().numBrushesOn +=1;
			else Destroy(col.gameObject);
		}
	}
	
	void OnMouseDown()
	{
		Debug.Log(Input.mousePosition.ToString());
	}
	
}


