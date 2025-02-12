using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            print("hit " + collision.gameObject.name + " !");
            Destroy(collision.gameObject); // Destroy the target
            Destroy(gameObject); // Destroy the bullet
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            print("hit a wall");
            Destroy(gameObject);
        }
    }
}
