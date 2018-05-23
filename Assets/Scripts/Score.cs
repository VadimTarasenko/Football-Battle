using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public void Goal()
    {
        int CourrenValue = System.Convert.ToInt32(this.GetComponent<Text>().text);
        this.GetComponent<Text>().text = System.Convert.ToString(++CourrenValue);
    }
}
