using UnityEngine;

public class Counter : MonoBehaviour {

    public Sprite[] sprites; // All sprites of player
    public int activeSprite; // Number of active sprite

    private void Start()
    {
        activeSprite = 0;
    }

    private void Update()
    {
        try
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[activeSprite];
        }
        catch(System.IndexOutOfRangeException)
        {
            Debug.Log("Out range");
        }
    }
}
