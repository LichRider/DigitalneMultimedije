using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Text zivoti;
    public Text poeni;
    public GameObject levelPanel;
    public GameObject deadPanel;
    // Use this for initialization
    void Start() {
        zivoti.text = "Lives: 5";
        poeni.text = "Score: 0";
    }

    private void showPanel(GameObject panel)
    {
        levelPanel.SetActive(false);
    }
    public void setLives(int n)
    {
        zivoti.text = "Lives: " + n;
    }

    public void setScore(int n)
    {
        poeni.text = "Score: " + n;
    }

    public void startLevel()
    {
        showPanel(levelPanel);
        levelPanel.SetActive(true);
    }

    public void dead()
    {
        showPanel(deadPanel);
        deadPanel.SetActive(true);
    }

    /*  public void Menu()
      {
          showPanel(menu);
      }

      putblic void SelectLevel()
      {
          showPanel(selectlevel);
      }
      public void Dead()
      {
          showPanel(dead);
      }
      public void ()
      {
          showPanel(dead);
      }
      // Update is called once per frame*/
    void Update () {
		
	}
}
