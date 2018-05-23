using UnityEngine;

public class BallPhisics : MonoBehaviour {
    
    private void OnCollisionEnter2D(Collision2D collisionObj)
    {

        // puls ball by player
        if(collisionObj.transform.name.Contains("Player"))
        {
            Vector2 moveDirection = new Vector2(collisionObj.gameObject.transform.position.x - this.transform.position.x, collisionObj.gameObject.transform.position.y - this.transform.position.y);
            this.GetComponent<Rigidbody2D>().AddForce((-moveDirection) * 5 + this.GetComponent<Rigidbody2D>().velocity.normalized, ForceMode2D.Impulse);
        }
    }

}