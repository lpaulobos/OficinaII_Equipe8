using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	public int scene;
	void OnMouseDown(){
		Application.LoadLevel (scene);
	}
}
