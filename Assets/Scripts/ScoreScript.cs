using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public Text scoreTextPanel;
    public bool alive;

    private void OnTriggerEnter(Collider other)
    {
        if (alive == true)
        {
            score++;
            scoreText.text = score.ToString();
            scoreTextPanel.text = score.ToString();
            Destroy(other.gameObject);
        }      
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
