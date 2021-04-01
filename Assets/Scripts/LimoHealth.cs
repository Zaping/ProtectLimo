using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LimoHealth : Health
{
    public Text healthText;
    public GameObject gameOverPanel;
    public GameObject ScoreManager;
    public GameObject LeftButton;
    public GameObject RightButton; 
    protected override void Update()
    {
        if (health <= 0)
            Die();
        healthText.text = health.ToString();
    }
    void Start()
    {
        health = 2;
    }
    protected override void Die()
    {
        LeftButton.SetActive(false);
        RightButton.SetActive(false);
        gameOverPanel.SetActive(true);
        ScoreManager.GetComponent<ScoreScript>().alive = false;
        Destroy(transform.parent.gameObject);
    }
}
