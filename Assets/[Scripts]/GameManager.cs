using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Gameplay Values")]
    public int score = 0;
    public int lives = 3;

    [Header("References")]
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI livesUI;
    public GameObject loseScreen;

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreUI.text = score.ToString();
    }

    public void TakeDamage(int damageToTake)
    {
        lives -= damageToTake;
        livesUI.text = lives.ToString();

        if (lives <= 0)
        {
            // Lose game
            loseScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
