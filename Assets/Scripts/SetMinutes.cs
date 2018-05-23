using UnityEngine;
using UnityEngine.UI;
using System;

public class SetMinutes : MonoBehaviour {

    [SerializeField] private Text timeValue;
    [SerializeField] private Scrollbar bar;
    private int matchTime;

    private void Update()
    {
        matchTime = (int)(2 + bar.value * 5);
        timeValue.GetComponent<Text>().text = matchTime + " min";
    }

    public int getTime()
    {
        return matchTime;
    }
}