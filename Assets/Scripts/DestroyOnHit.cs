using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{

    public AudioClip explsSound;
    public GameObject explosionEffect;
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            PlayExplosionSound();
            Destroy(gameObject, 0.5f);
            Destroy(collision.gameObject, 0.05f); 
        }
    }

    private void PlayExplosionSound()
    {
        AudioSource.PlayClipAtPoint(explsSound, transform.position);
    }
}
 