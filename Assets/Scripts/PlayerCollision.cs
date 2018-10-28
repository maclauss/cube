using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

	// Use this for initialization
	void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            Debug.Log("We hit " + collisionInfo.collider.tag);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
