using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIScript : MonoBehaviour {

    public Text zivoti;
    public Text poeni;
    public GameObject levelPanel;
    public GameObject deadPanel;
    public GameObject startPanel;
    public GameObject selectPanel;
    // Use this for initialization
    void Start() {
        zivoti.text = "Lives: 5";
        poeni.text = "Score: 0";
    }
    public void setLives(int n)
    {
        zivoti.text = "Lives: " + n;
    }

    public void setScore(int n)
    {
        poeni.text = "Score: " + n;
    }

    public void showPanel(GameObject panel)
    {
        startPanel.SetActive(false);
        selectPanel.SetActive(false);
        levelPanel.SetActive(false);
        deadPanel.SetActive(false);

        if (panel != null)
            panel.SetActive(true);

    }
    public void StartPanel()
    {
        showPanel(startPanel);
    }

    public void SelectPanel()
    {
        showPanel(selectPanel);
    }
    public void StartLevel()
    {
        showPanel(levelPanel);
        Debug.Log("Ovo radi");
    }

    public void dead()
    {
        showPanel(deadPanel);
    }

    /* 

      
 
      // Update is called once per frame*/
    void Update () {
		
	}
}
