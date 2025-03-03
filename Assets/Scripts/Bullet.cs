using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 3f; // Time before the bullet is destroyed.

    void Start()
    {
        // Destroy after a set amount of time.
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        Destroy(gameObject);
    }
}
