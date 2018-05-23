using UnityEngine;

public class ChangeFaceBt : MonoBehaviour {

    public GameObject PlayerFace;
    public bool isRightBt;

    private void OnMouseDown()
    {
        ChangeFace();
    }

    private void OnMouseEnter()
    {
        // Light up a button
        this.GetComponent<SpriteRenderer>().color = new Color(this.GetComponent<SpriteRenderer>().color.r,
                                                              this.GetComponent<SpriteRenderer>().color.g,
                                                              this.GetComponent<SpriteRenderer>().color.b, 1.0f);
    }

    private void OnMouseExit()
    {
        // Darken a button
        this.GetComponent<SpriteRenderer>().color = new Color(this.GetComponent<SpriteRenderer>().color.r,
                                                              this.GetComponent<SpriteRenderer>().color.g,
                                                              this.GetComponent<SpriteRenderer>().color.b, 0.7f);
    }

    private void ChangeFace()
    {
        if(isRightBt)
        {
            
            if (PlayerFace.GetComponent<Counter>().sprites.Length - 1 == PlayerFace.GetComponent<Counter>().activeSprite)
                PlayerFace.GetComponent<Counter>().activeSprite = 0;
            else
                PlayerFace.GetComponent<Counter>().activeSprite += 1;
        }
        else
        {
            if (PlayerFace.GetComponent<Counter>().activeSprite == 0)
                PlayerFace.GetComponent<Counter>().activeSprite = PlayerFace.GetComponent<Counter>().sprites.Length;
            else
                PlayerFace.GetComponent<Counter>().activeSprite -= 1;
        }
    }
}
