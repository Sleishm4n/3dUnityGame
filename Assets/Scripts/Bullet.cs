using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 3f; // Time before the bullet is destroyed.

    void Start()
    {
        // Destroy the bullet after a set amount of time.
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Destroy the bullet on collision.
        Destroy(gameObject);
        
        // Optional: Handle damage to target here.
        // Example:
        // if (collision.gameObject.CompareTag("Enemy"))
        // {
        //     // Apply damage to the enemy.
        // }
    }
}
