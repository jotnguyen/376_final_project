using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{

    private int score = 0;
    private int health = 3;
    public TMP_Text healthText;
    public TMP_Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScorePoint()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();

        if (score == 3)
        {
            NextLevel();
        }
    }

    public void HealthLoss()
    {
        health--;
        healthText.text = "Health: " + health.ToString();
        
        if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
