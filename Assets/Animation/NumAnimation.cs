using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumAnimation : MonoBehaviour {

    private void Start() {
        
    }

    private void Update() {
        this.GetComponent<SpriteRenderer>().color = new Color(255.0f, 255.0f, 255.0f, this.GetComponent<SpriteRenderer>().color.a - 0.02f);
        this.transform.localScale = new Vector3(this.transform.localScale.x + 0.1f, this.transform.localScale.y + 0.1f, this.transform.localScale.z);
    }
}
