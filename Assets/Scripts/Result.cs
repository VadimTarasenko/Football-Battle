using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {

    [SerializeField] private Text whoWinText;
    [SerializeField] private Text scoreText;
    private GameObject scoreLeftPlayer;
    private GameObject scoreRightPlayer;

    private void Start()
    {
        scoreLeftPlayer = GameObject.Find("LeftPlayerScore");
        scoreRightPlayer = GameObject.Find("RightPlayerScore");
        string allScore = scoreLeftPlayer.GetComponent<Text>().text + " : " + scoreRightPlayer.GetComponent<Text>().text;
        scoreText.text = allScore;
        if(System.Convert.ToInt32(scoreLeftPlayer.GetComponent<Text>().text) > System.Convert.ToInt32(scoreRightPlayer.GetComponent<Text>().text))
        {
            whoWinText.text = "Player 1 win!";
        }
        else if (System.Convert.ToInt32(scoreLeftPlayer.GetComponent<Text>().text) < System.Convert.ToInt32(scoreRightPlayer.GetComponent<Text>().text))
        {
            whoWinText.text = "Player 2 win!";
        }
        else
        {
            whoWinText.text = "Won friendship!";
        }
    }

}
