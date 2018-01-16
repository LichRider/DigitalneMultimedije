using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public enum GameState
    {
        menu,
        selectLevel,
        startLevel,
        endLevel,
        dead,
        gameover
    }
    public static GameState gameState;
    public Kretanje kretanje;
    private int score;
    private int lives;
    public UIScript uiScript;
    // Use this for initialization
    void Start() {
        startLevel();
        score = 0;
        lives = 5;
    }

    public void Menu()
    {
        
        gameState = GameState.menu;
    }
    public void SelectLevel()
    {
        gameState = GameState.selectLevel;
       // uiScript.selectLevel();
    }
    public void startLevel()
    {
       
        gameState = GameState.startLevel;
        uiScript.setLives(lives);
        uiScript.setScore(score);
        uiScript.startLevel();
        kretanje.Begin();
    }
    public void EndLevel()
    {
        gameState = GameState.endLevel;
    }
    public void Dead()
    {
        gameState = GameState.dead;
        uiScript.dead();
    }
    public void GameOver()
    {
        gameState = GameState.gameover;
    }

    public void DetectedEnemy()
    {
        lives--;
        if (lives == 0)
            GameOver();
        else
            Dead();
        uiScript.setLives(lives);
    }

  
    public void DetectedCoin()
    {
        if(gameState==GameState.startLevel)
        {
            if (score == 10)
            {
                lives++;
                score = 0;
            }
            else
                score++;
        }
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
