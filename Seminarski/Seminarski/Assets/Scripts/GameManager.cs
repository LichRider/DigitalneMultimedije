using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
    public AudioScript audioScript;
    private int score;
    private int lives;
    public UIScript uiScript;
    // Use this for initialization
    void Start() {
        score = 0;
        lives = 5;
        Menu();
       
    }

    public void Menu()
    {
        gameState = GameState.menu;
        uiScript.StartPanel();
    }
    public void SelectLevel()
    {
        gameState = GameState.selectLevel;
        uiScript.SelectPanel();
        
    }
    public void startLevel()
    {
       
        gameState = GameState.startLevel;
        uiScript.setLives(lives);
        uiScript.setScore(score);
        uiScript.StartPanel();
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
            {
                score++;
                audioScript.GetCoin();
            }
        }
        uiScript.setScore(score);
        uiScript.setLives(lives);
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
