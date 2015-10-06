using UnityEngine;
using System.Collections;

public class testTouch : MonoBehaviour {
	
	public Vector3 fingerPos;
	public Vector3 realWorldPos;
	void Update()
	{
		if(Input.touchSupported)
		{
			fingerPos = Input.GetTouch(0).position;
			Vector3 pos = fingerPos;
			realWorldPos = Camera.main.ScreenToWorldPoint(pos);
			realWorldPos.z = 0;
			transform.localPosition = realWorldPos; 
		}else
		{
			if(Input.GetKey(KeyCode.A))
			{transform.position = new Vector3 (this.transform.position.x - 0.05f,
											   this.transform.position.y,
				                               this.transform.position.z);
         	}
			if((Input.GetKey(KeyCode.D))){
				transform.position = new Vector3 (this.transform.position.x + 0.05f,
				                                  this.transform.position.y,
				                                  this.transform.position.z);
			}
			if((Input.GetKey(KeyCode.W))){
				transform.position = new Vector3 (this.transform.position.x,
				                                  this.transform.position.y + 0.05f,
				                                  this.transform.position.z);
			}
			
			if((Input.GetKey(KeyCode.S))){
				transform.position = new Vector3 (this.transform.position.x,
				                                  this.transform.position.y - 0.05f,
				                                  this.transform.position.z);
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
	
}


