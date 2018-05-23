using UnityEngine;

public class PlayerContrl : MonoBehaviour {

    // move speed
    [SerializeField] private float runningSpeed = 8.0f;
    [SerializeField] private float turningSpeed = 5f;

    private void Update()
    {
        if (!TimeController.ImitatePause)
        {
            Control();
        }
    }

    private void Control()
    {
        // set controls for both players
        if (this.name == "LPlayer") ControlWADS();
        else ControlArrows();
    }

    private void ControlArrows()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.down * runningSpeed * Time.deltaTime);
            PlayAnimation();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.up * runningSpeed * Time.deltaTime);
            PlayAnimation();
        }
        else
        {
            StopAnimation();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z + turningSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - turningSpeed);
        }
    }

    private void ControlWADS()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.down * runningSpeed * Time.deltaTime);
            PlayAnimation();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.up * runningSpeed * Time.deltaTime);
            PlayAnimation();
        }
        else
        {
            StopAnimation();
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z + turningSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - turningSpeed);
        }
    }

    private void PlayAnimation()
    {
        this.GetComponent<Animator>().SetBool("isMove", true);
    }

    private void StopAnimation()
    {
        this.GetComponent<Animator>().SetBool("isMove", false);
    }
}