using UnityEngine;
using System.Collections;

public class MenuHandler : MonoBehaviour {

	public GameObject OptionsCanvas;
	private bool isShowing;



	public void MainMenuButtonsHandler ( string ChangeMenuTo)
	{
		Application.LoadLevel(ChangeMenuTo);
	}

	public void QuitGame()
	{

		if ( UnityEditor.EditorApplication.isPlaying == true)
			UnityEditor.EditorApplication.isPlaying = false;

		else
			Application.Quit();
	}



	public  void CheckForPause()
	{

		isShowing = !isShowing;
		OptionsCanvas.SetActive(isShowing);


	}
}
