using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour {

    public bool Pause;
    public static bool ImitatePause = false;

    private void Start() {
        Pause = false;
        Time.timeScale = 1.0f;
    }

    private void Update() {
        IsPause(); // Check pause
    }

    private void IsPause() {
        if (Pause == true && Time.timeScale != 0.0f) {
            Time.timeScale = 0.0f;
        }
        if (Pause == false && Time.timeScale != 1.0f) {
            Time.timeScale = 1.0f;
        }
    }
}
