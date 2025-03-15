using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private GameObject gameLogic; // Reference to GameLogic

    void Start()
    {
        // Find the GameLogic object in the scene
        gameLogic = GameObject.FindWithTag("GameLogic");

        if (gameLogic == null)
        {
            Debug.LogError("GameLogic object not found! Make sure it has the 'GameLogic' tag.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            print("Hit " + collision.gameObject.name + " !");
            
            // Update the target count
            if (gameLogic != null)
            {
                gameLogic.GetComponent<GameLogic>().targetCount += 1;
                gameLogic.GetComponent<GameLogic>().UpdateCounterUI(); // Update UI
            }

            Destroy(collision.gameObject); // Destroy the target
            Destroy(gameObject); // Destroy the bullet
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            print("Hit a wall");
            Destroy(gameObject);
        }
    }
}
