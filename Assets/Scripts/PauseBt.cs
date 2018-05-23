using UnityEngine;

public class PauseBt : MonoBehaviour {

    public GameObject TimeContr;
    public GameObject PauseDesk;
    public GameObject Parent;

    private void OnMouseDown()
    {
        TimeContr.GetComponent<TimeController>().Pause = true;
        TimeController.ImitatePause = true;
        Instantiate(PauseDesk, Parent.transform);
    }
}
