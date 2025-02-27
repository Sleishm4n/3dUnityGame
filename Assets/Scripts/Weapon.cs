using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the bullet prefab.
    public Transform firePoint; // The point where bullets are spawned.
    public float bulletForce = 20f; // The speed of the bullet.

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the bullet at the fire point.
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        // Make bullet move in the direction of the camera
        rb.linearVelocity = Camera.main.transform.forward * bulletForce;
    }
}
