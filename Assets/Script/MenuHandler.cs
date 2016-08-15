using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{

	public GameObject OptionsCanvas;
	private bool isShowing;



	public void MainMenuButtonsHandler ( string ChangeMenuTo)
	{
		SceneManager.LoadScene(ChangeMenuTo);
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

	public void TogglePanel (GameObject panel) 
	{
		panel.SetActive (!panel.activeSelf);
	}
}
