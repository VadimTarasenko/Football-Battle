using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counting : MonoBehaviour {

    [SerializeField] private GameObject Num1;
    [SerializeField] private GameObject Num2;
    [SerializeField] private GameObject Num3;
    [SerializeField] private GameObject Go;

    private float StartTime;
    private GameObject Number1;
    private GameObject Number2;
    private GameObject Number3;
    private GameObject GoMessage;

    private void Start() {
        StartTime = Time.time;
        Number1 = Instantiate(Num1);
    }

    private void Update() {
        if(Time.time - StartTime > 1.0f && Time.time - StartTime <= 2.0f && Number2 == null) {
            Destroy(Number1);
            Number2 = Instantiate(Num2);
        }
        else if(Time.time - StartTime > 2.0f && Time.time - StartTime <= 3.0f && Number3 == null) {
            Destroy(Number2);
            Number3 = Instantiate(Num3);
        }
        else if (Time.time - StartTime > 3.0f && Time.time - StartTime <= 4.0f && GoMessage == null) {
            Destroy(Number3);
            GoMessage = Instantiate(Go);
            this.GetComponent<AudioSource>().Play();
        } 
        else if(Time.time - StartTime > 4.0f) {
            Destroy(GoMessage);
            TimeController.ImitatePause = false;
            Destroy(this.gameObject);
        }
    }
}
