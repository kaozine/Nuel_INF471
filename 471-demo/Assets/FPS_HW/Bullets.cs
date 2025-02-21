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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            print("Hit Enemy! Enemy defeated.");
            Destroy(other.gameObject); // Destroy the enemy
            Destroy(gameObject); // Destroy the bullet
        }
        else if (other.CompareTag("Wall"))
        {
            print("Hit a wall");
            Destroy(gameObject);
        }
    }
}
