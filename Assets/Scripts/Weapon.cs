using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the bullet prefab.
    public Transform firePoint; // The point where bullets are spawned.
    public float bulletForce = 20f; // The speed of the bullet.

    void Update()
    {
        // Check for shooting input.
        if (Input.GetButtonDown("Fire1")) // Left mouse button or equivalent.
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the bullet at the fire point.
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        // Add force to the bullet's Rigidbody to propel it forward.
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
        }
    }
}
