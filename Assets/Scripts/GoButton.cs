using UnityEngine;
using UnityEngine.SceneManagement;

public class GoButton : MonoBehaviour {

    public GameObject Time;
    public GameObject DeskPlayer1;
    public GameObject DeskPlayer2;

    private void OnMouseDown()
    {
        Save();
        SceneManager.LoadScene("GameProcess");
    }

    private void Save()
    {
        int gameTime = Time.GetComponent<SetMinutes>().getTime();
        string leftPlayerName = DeskPlayer1.GetComponent<SpriteRenderer>().sprite.name;
        string rightPlayerName = DeskPlayer2.GetComponent<SpriteRenderer>().sprite.name;
        PlayerPrefs.SetString("LeftPlayerName", leftPlayerName);
        PlayerPrefs.SetString("RightPlayerName", rightPlayerName);
        PlayerPrefs.SetInt("GameTime", gameTime);
        PlayerPrefs.Save();
    }
}
