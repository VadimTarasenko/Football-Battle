using UnityEngine;

public class Goal : MonoBehaviour {

    public GameObject leftPlayer;
    public GameObject rightPlayer;
    [SerializeField] private GameObject lefTeamScore;      
    [SerializeField] private GameObject rightTeamScore;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject timeController;
    [SerializeField] private GameObject goalAlertPrefab;
    [SerializeField] private GameObject goalReaction;

    private string whoTakeGoal;
    private GameObject _goalReaction;
    private GameObject goalAlertObj;
    public bool isGoal;

    private void OnTriggerEnter2D(Collider2D CollisionObj) {
        if (CollisionObj.gameObject.name == "Ball") {
            _goalReaction = Instantiate(goalReaction); _goalReaction.GetComponent<AudioSource>().Play();
            isGoal = true;
            // change game score
            if(this.gameObject.name == "Goal1") {
                whoTakeGoal = "RightPlayer";
                rightTeamScore.GetComponent<Score>().Goal();
            } else {
                whoTakeGoal = "LeftPlayer";
                lefTeamScore.GetComponent<Score>().Goal();
            }
        }
    }

    private bool once = false;
    private float goalTime = 1000.0f;
    private void Update() {
        if(isGoal == true) {       // if anyone was scoring goal
            if (once == false) {   // show goal alert once
                GoalAlert();
                once = true;
            }
            // make default positions
            if (whoTakeGoal == "RightPlayer") {
                if(goalAlertObj == null) {
                    RightPlayerBreed();
                    DefaultData();
                }
            } else {
                if(goalAlertObj == null) {
                    LeftPlayerBreed();
                    DefaultData();
                }
            }
        }
        if(_goalReaction != null)
            if (_goalReaction.GetComponent<AudioSource>().isPlaying == false)
                Destroy(_goalReaction);
    }

    private void RightPlayerBreed() {
        // Set ball position
        ball.transform.position = new Vector3(0.0f, 0.0f, ball.transform.position.z);
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        // Set left player position and roatation
        if (leftPlayer != null) { 
            leftPlayer.transform.localPosition = new Vector3(-2.5f, 0.0f, leftPlayer.transform.localPosition.z);
            leftPlayer.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
        }

        // Set right player position and roatation
        if (rightPlayer != null) {
            rightPlayer.transform.localPosition = new Vector3(6.0f, 0.0f, rightPlayer.transform.localPosition.z);
            rightPlayer.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, -90.0f);
        }
    }

    private void LeftPlayerBreed() {
        // Set ball position
        ball.transform.position = new Vector3(0.0f, 0.0f, ball.transform.position.z);
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;

        // Set right player position and roatation
        if (rightPlayer != null) {
            rightPlayer.transform.localPosition = new Vector3(2.5f, 0.0f, rightPlayer.transform.localPosition.z);
            rightPlayer.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, -90.0f);
        }

        // Set left player position and roatation
        if (leftPlayer != null) {
            leftPlayer.transform.localPosition = new Vector3(-6.0f, 0.0f, leftPlayer.transform.localPosition.z);
            leftPlayer.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
        }
    }

    private void GoalAlert() {
        goalAlertObj = Instantiate(goalAlertPrefab);
    }

    private void DefaultData() {
        once = false;
        isGoal = false;
        whoTakeGoal = "";
    }
}
