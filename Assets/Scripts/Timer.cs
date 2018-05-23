using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [SerializeField] private GameObject Minutes;
    [SerializeField] private GameObject Seconds;
    [SerializeField] private GameObject EndDesk;
    [SerializeField] private GameObject timeController;
    private Transform parent;
    private int min, sec;


    private void Start() {
        parent = GameObject.Find("Canvas").transform;
        min = PlayerPrefs.GetInt("GameTime");
        sec = 0;
        SetTime(min, 0);
    }

    int tempTime = 0;
    private void FixedUpdate() {
        if (TimeController.ImitatePause == false)
        {
            if (tempTime == (int)Time.time)
            {

            }
            else
            {
                tempTime = (int)Time.time;
                if (sec == 0)
                {
                    sec = 60;
                    min--;
                }
                else
                {
                    sec--;
                }
                SetTime(min, sec);
            }
        }
    }

    private void SetTime(int min, int sec) {
        if (min <= 0 && sec <= 0) DrawEndDesk();
        else
        {
            Minutes.GetComponent<Text>().text = "0" + System.Convert.ToString(min);
            if (sec > 9) Seconds.GetComponent<Text>().text = System.Convert.ToString(sec);
            else Seconds.GetComponent<Text>().text = "0" + System.Convert.ToString(sec);
        }
    }

    private void DrawEndDesk()
    {
        GameObject.Find("TimeController").GetComponent<TimeController>().Pause = true;
        Instantiate(EndDesk, parent);
    }
}
