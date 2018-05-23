using UnityEngine;

public class ResumeBt : MonoBehaviour {

    public GameObject Desk; // Pause menu

    private void OnMouseDown()
    {
        GameObject.Find("TimeController").GetComponent<TimeController>().Pause = false;
        TimeController.ImitatePause = false;
        Destroy(Desk);
    }
}