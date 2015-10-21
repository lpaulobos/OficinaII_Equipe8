using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {
	
	private static float[] array = new float[5]{0.3f,0.5f,-0.5f,-0.3f, 0.0f}; 
	private int i;
	private int count;
    private int direction;
    private float aceleration;
    private bool rada;

    // Use this for initialization
    void Start () {
		i = 0;
		count = 0;
        aceleration = Random.Range(2, 10) / 10;
        direction = Mathf.RoundToInt(Random.Range(-1, 2));
        rada = false;
        PlayerPrefs.SetInt("time", 0);
        PlayerPrefs.SetInt("points", 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count++;

        if (this.gameObject.name == "Ponteiro") {
            this.transform.eulerAngles = new Vector3(0, 0, this.transform.eulerAngles.z - 1);
            if (count >= 5)
            {
                PlayerPrefs.SetInt("time", PlayerPrefs.GetInt("time") + 1);
                count = 0;
                Debug.Log("Setou " + PlayerPrefs.GetInt("time").ToString());
            }

        }
        if (this.gameObject.tag == "bus" && count >= 5)
        {
            this.transform.eulerAngles = new Vector3(0, 0, this.transform.eulerAngles.z + array[i]);
            i += 1;
            count = -20;
            if (i > 4) i = 0;
        }
        if (this.gameObject.tag == "Player")
        {
            
            if (rada)
            {
                aceleration += 0.005f;
                if (direction > 0) this.transform.eulerAngles = new Vector3(0, 0, this.transform.eulerAngles.z + aceleration);
                else this.transform.eulerAngles = new Vector3(0, 0, this.transform.eulerAngles.z + aceleration);
                aceleration -= Input.acceleration.x / 10;

                if (this.transform.eulerAngles.z > 60 && this.transform.eulerAngles.z < 300)
                {
                    PlayerPrefs.SetInt("points", PlayerPrefs.GetInt("points") - 10);
                    Application.LoadLevel(6);
                }
                else   

                if (this.transform.eulerAngles.z > -2 && this.transform.eulerAngles.z < 2)
                    rada = false;
                    aceleration = 0;
            }else StartCoroutine(wait());
        }
    }
    void OnTriggerStay(Collider col)
    {
        if(this.gameObject.tag == "bus") {
            if (Input.GetMouseButtonDown(0))
            {
                if (col.gameObject.tag == "escola") { 
                    PlayerPrefs.SetInt("points", 400);
                    Application.LoadLevel(6);
                }
                else
                PlayerPrefs.SetInt("points", PlayerPrefs.GetInt("points") - 50);
            }
        }
        
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        rada = true;
    }

}
