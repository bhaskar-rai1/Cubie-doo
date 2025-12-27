using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) // Collision tell unity that we want to gather some information about the collision we made. 
    // and collisionInfo will be the name of that information
    {
        if (collisionInfo.collider.tag == "Obstacle") // (collisionInfo.collider.name == "Obstacle") searching by object name is not the bbest practice to be followed.
        // what if the name changes. and plus it is taxing on computer.
        // instead use Tags they can be used to group objects together.
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
