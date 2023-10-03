using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Declares lives and score variables
    private int score = 0;
    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Checks if there are zero lives and gives you game over if at zero
    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over! You were killed :(");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }

    // Checks score and tells it to player
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}
