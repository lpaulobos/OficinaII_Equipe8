using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text conceito;
    public Text tempo;
    public Text pontos;
    private int clicks;


    void Start () {
        conceito = GetComponent<Text>();
        tempo = GetComponent<Text>();
        pontos = GetComponent<Text>();
    }
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            clicks += 1;
        }
        if (clicks >= 4)
        {
            PlayerPrefs.DeleteAll();
            Application.LoadLevel(0);
        }
        switch (this.gameObject.name)
        {
            case "nota":
                if (clicks >= 1) conceito.text = "Conceito: " + PlayerPrefs.GetInt("points").ToString();
                break;
            case "tempo":
                if (clicks >= 2) tempo.text = "Tempo: " + PlayerPrefs.GetInt("time").ToString() ;
                break;
            case "ponto":
                if (clicks >= 3) pontos.text = "Pontuação: " + (PlayerPrefs.GetInt("points") - PlayerPrefs.GetInt("time")).ToString();
                break;
        }
	}
}
