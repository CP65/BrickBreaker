using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Text winText;

    public int numOfBricks = 10;

    public bool gameWon = false;

    // Get access to losing collider
    public GameLostScript gameLost;

    // Get access to Play and Quit buttons
    public Image playButton, quitButton;

    // Start is called before the first frame update
    void Start()
    {
        winText.text = " ";
        gameLost = GameObject.FindWithTag("LoseCollider").GetComponent<GameLostScript>();
        playButton = GameObject.FindWithTag("Button").GetComponent<Image>();
        playButton.enabled = false;
        
        quitButton = GameObject.FindWithTag("QuitButton").GetComponent<Image>();
        quitButton.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameWon();
        SetWinScreen();
        SetLoseScreen();
    }

    public void IncreaseScore()
	{
        score++;
        scoreText.text = "Score: " + score;
	}

    public void GameWon()
	{
        if (score == numOfBricks)
        {
            gameWon = true;
        }
    }

    void SetWinScreen()
	{
		if (gameWon)
		{
            winText.text = "YOU WIN!";
            playButton.enabled = true;
            quitButton.enabled = true;
        }
	}
	
	void SetLoseScreen()
	{
        if (gameLost.lostGame)
		{
            winText.text = "Jy's poes kak";
            playButton.enabled = true;
            quitButton.enabled = true;
        }
	}

}
