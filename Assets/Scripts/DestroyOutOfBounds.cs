using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Declares out of bounds ranges
    private float topBound = 30;
    private float lowerBound = -14;

    // Declares GameManager variable - DELETE IF IT DOESNT WORK OUT
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // References the GameManager variable - DELETE IF IT DOESNT WORK OUT
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Makes object disappear if out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            // Debug.Log("Game Over! Your garden was destroyed! :("
            Destroy(gameObject);
        }
    }
}
