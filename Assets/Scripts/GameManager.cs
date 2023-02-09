using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text pointText;
    public TMP_Text gameOverText;
    
    private int _playerPoints = 0;
    private bool _gameOver;
    
    void Start()
    {
    if (gameOverText != null)
        gameOverText.enabled = false;
    }
    
    void Update()
    {
    if (_gameOver)
    {
        if (Input.GetKey(KeyCode.R))
            Restart();
    }
    }
    
    public void AddPoints()
    {
    _playerPoints += 10;
    pointText.text = "Points: " + _playerPoints;
    }
    
    public void GameOver()
    {
    _gameOver = true;
    gameOverText.enabled = true;
    }
    
    private void Restart()
    {
    _gameOver = false;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
