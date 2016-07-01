using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public Image GameOverImage;

	public Color GameColor, GameOverColor, GameOverTextColor, GameOverButtonsColor;

	public float ColorChangeSpeed;

	bool IsGameOver;

	public Text GameOverText, ScoreText, BestScoreText;

	public Button RetryButton, MenuButton;

	// Use this for initialization
	void Start () 
	{
		Time.timeScale = 1;
		IsGameOver = false;
		GameOverImage.color = GameColor;
		GameOverImage.gameObject.SetActive (false);
		RetryButton.gameObject.SetActive (false);
		MenuButton.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (IsGameOver) 
		{
			Time.timeScale = 0;
			GameOverImage.gameObject.SetActive (true);
			GameOverImage.color = Color.Lerp (GameOverImage.color, GameOverColor, ColorChangeSpeed);
			GameOverText.color = Color.Lerp (GameOverText.color, GameOverTextColor, ColorChangeSpeed);
		}

		if (Input.GetKey (KeyCode.Space)) 
		{
			IsGameOver = true;
		}
		if (GameOverImage.color.a >= 0.6f) 
		{
			ScoreText.color = Color.Lerp (ScoreText.color, GameOverButtonsColor, ColorChangeSpeed);
			BestScoreText.color = Color.Lerp (BestScoreText.color, GameOverButtonsColor, ColorChangeSpeed);
		}
		if (ScoreText.color.a >= 0.8f) 
		{
			RetryButton.gameObject.SetActive (true);
			MenuButton.gameObject.SetActive (true);
			RetryButton.image.color = Color.Lerp (RetryButton.image.color, GameOverButtonsColor, ColorChangeSpeed);
			MenuButton.image.color = Color.Lerp (RetryButton.image.color, GameOverButtonsColor, ColorChangeSpeed);
		}
	}

	void OnCollisionEnter2D(Collision2D Col)
	{
		if (Col.gameObject.tag == "enemies") 
		{
			IsGameOver = true;
		}
	}
}
