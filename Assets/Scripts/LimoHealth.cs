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
    // Start is called before the first frame update
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
        gameOverPanel.SetActive(true);
        ScoreManager.GetComponent<ScoreScript>().alive = false;
        Destroy(transform.parent.gameObject);
    }
}
