using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalAlertAnimation : MonoBehaviour {

    [SerializeField] private GameObject CountObj;

    private void Start() {
        TimeController.ImitatePause = true;
    }

    private void Update() {
        this.GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, this.GetComponent<SpriteRenderer>().color.a - 0.01f);
        this.transform.localScale = new Vector3(this.transform.localScale.x + 0.07f, this.transform.localScale.y + 0.07f, this.transform.localScale.z);

        if(this.GetComponent<SpriteRenderer>().color.a <= 0.0f) {
            Instantiate(CountObj);
            Destroy(this.gameObject);
        }
    }
}
