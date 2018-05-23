using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {

    [SerializeField] private GameObject RigidBody; // Object for shadow
    [SerializeField] private float x, y; // differens position betwen body and shadow

    private void Update()
    {
        this.transform.position = new Vector3(RigidBody.transform.position.x + x, RigidBody.transform.position.y + y, this.transform.position.z);
    }
}
