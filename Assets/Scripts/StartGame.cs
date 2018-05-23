using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public Sprite MessiSprite,
                  ZidanSprite,
                  NigerSprite;
    public GameObject LeftPlayer;
    public GameObject RightPlayer;
    public RuntimeAnimatorController MessiAnimController;
    public RuntimeAnimatorController ZidanAnimController;
    public RuntimeAnimatorController NigaAnimController;
    public GameObject timer;
    public GameObject timeController;


    private GameObject startAlert;
    private void Start()
    {
        timeController.GetComponent<TimeController>().Pause = true;
        TimeController.ImitatePause = true;
        startAlert = Instantiate(timer);
        SetData();
    }


    private bool flag = true;
    private void Update()
    {
        if (startAlert == null && flag)
        {
            timeController.GetComponent<TimeController>().Pause = false;
            TimeController.ImitatePause = false;
            flag = false;
        }
    }

    private void SetData()
    {
        if(PlayerPrefs.GetString("LeftPlayerName") == "Messi")
        {
            LeftPlayer.GetComponent<SpriteRenderer>().sprite = MessiSprite;
            LeftPlayer.GetComponent<Animator>().runtimeAnimatorController = MessiAnimController;
        }
        else if(PlayerPrefs.GetString("LeftPlayerName") == "Zidan")
        {
            LeftPlayer.GetComponent<SpriteRenderer>().sprite = ZidanSprite;
            LeftPlayer.GetComponent<Animator>().runtimeAnimatorController = ZidanAnimController;
        }
        else
        {
            LeftPlayer.GetComponent<SpriteRenderer>().sprite = NigerSprite;
            LeftPlayer.GetComponent<Animator>().runtimeAnimatorController = NigaAnimController;
        }

        if (PlayerPrefs.GetString("RightPlayerName") == "Messi")
        {
            RightPlayer.GetComponent<SpriteRenderer>().sprite = MessiSprite;
            RightPlayer.GetComponent<Animator>().runtimeAnimatorController = MessiAnimController;
        }
        else if (PlayerPrefs.GetString("RightPlayerName") == "Zidan")
        {
            RightPlayer.GetComponent<SpriteRenderer>().sprite = ZidanSprite;
            RightPlayer.GetComponent<Animator>().runtimeAnimatorController = ZidanAnimController;
        }
        else
        {
            RightPlayer.GetComponent<SpriteRenderer>().sprite = NigerSprite;
            RightPlayer.GetComponent<Animator>().runtimeAnimatorController = NigaAnimController;
        }
    }
}
