using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Declares movement variables or something idk
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;

    // Declares bullet prefab
    public GameObject bulletPrefab;

    // Declares bullet spawnpoint
    public Transform bulletSpawnPoint;

    // Addes more movement along Z axis for player
    public float zMin;
    public float zMax;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Gets input from user for movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // Keeps user in certain bounds along X axis
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Keeps user in certain bounds along Z axis
        if(transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        if(transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

        // Checks if spacebar is pressed (to allow bullet to be projectile on command)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from user
            Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletPrefab.transform.rotation);
        }
    }
}
