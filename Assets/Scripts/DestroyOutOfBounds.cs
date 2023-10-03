using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Declares out of bounds ranges
    private float topBound = 30;
    private float lowerBound = -14;

    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("Game Over! They destroyed your garden :(");
            Destroy(gameObject);
        }
    }
}
