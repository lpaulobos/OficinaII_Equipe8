using UnityEngine;
using System.Collections;

public class click : MonoBehaviour {
    Animator a;
    Animation b;
    void Start()
    {
        a = GameObject.Find("porta").GetComponent<Animator>();
        b = GameObject.Find("porta").GetComponent<Animation>();
    }
    void OnMouseDown()
    {
        if (this.gameObject.name == "banheiro") {
            GameObject.Find("boy").transform.position = new Vector2 (this.transform.position.x, GameObject.Find("boy").transform.position.y+ 0.8f);
            a.SetBool("clickou", true);
            StartCoroutine(sceneDelay(a.GetCurrentAnimatorStateInfo(0).length));
        }
    }
    IEnumerator sceneDelay(float _time)
    {
        yield return new WaitForSeconds(_time);
        Application.LoadLevel("Fase3");
    }

}
