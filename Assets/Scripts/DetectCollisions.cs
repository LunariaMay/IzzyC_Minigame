using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DetectCollisions : MonoBehaviour
{
    // Declares GameManager variable - DELETE IF IT DOESNT WORK OUT
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        // References GameManager variable - DELETE IF IT DOESNT WORK OUT
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Destroys objects upon collision
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1); // DELETE IF GAMEMANAGER STUFF DOESNT WORK OUT
            // Debug.Log("Game Over! Your garden was destroyed! :("); - PUT BACK IF GAMEMANAGER STUFF DOESNT WORK OUT
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Bullet"))
        // else (other.CompareTag("Enemy")) - PUT BACK IF GAMEMANAGER STUFF DOESNT WORK OUT
        {
            gameManager.AddScore(5); // DELETE IF GAMEMANAGER STUFF DOESNT WORK OUT
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    } 
    
}
