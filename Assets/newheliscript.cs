using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newheliscript : MonoBehaviour
{
    Rigidbody rb;
    public GameObject missile;
    public Transform missileSpawnPoint;  // Spawn point for the missile
    public float missileSpeed = 500f;    // Speed of the missile

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Control the helicopter's height
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position.y < 200)
                rb.AddForce(0, 10, 0);
        }

        // Fire the missile when 'F' is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            FireMissile();
        }
    }

    private void FireMissile()
    {
        // Instantiate the missile at the specified spawn point
        GameObject firedMissile = Instantiate(missile, missileSpawnPoint.position, missileSpawnPoint.rotation);

        // Get the Rigidbody component of the missile to apply force
        Rigidbody missileRb = firedMissile.GetComponent<Rigidbody>();

        // Check if the missile has a Rigidbody and apply forward force
        if (missileRb != null)
        {
            missileRb.AddForce(missileSpawnPoint.forward * missileSpeed);
        }
        else
        {
            Debug.LogWarning("Missile prefab needs a Rigidbody component.");
        }
    }

    void FixedUpdate()
    {
        // Control helicopter movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(15, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddRelativeForce(-15, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -0.5f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 v = transform.position;
            v.y -= 7;
            Instantiate(missile, v, transform.rotation);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Cube"))
        {
            Destroy(collision.gameObject);
        }
    }
}
