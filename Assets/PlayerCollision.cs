using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement move;

    public void OnCollisionEnter(Collision collision)
    {
      if (collision.collider.tag == "obstacle")
          {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

      if (collision.collider.tag == "next")
        {
            
            Debug.Log("next");
            FindObjectOfType<GameManager>().NextGame();
        }
    }
}
