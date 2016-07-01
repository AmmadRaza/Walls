using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {

	public Canvas HUDCanvas, PauseCanvas;

	// Use this for initialization
	void Start () 
	{
		PauseCanvas.gameObject.SetActive (false);
		HUDCanvas.gameObject.SetActive (true);
	}

	public void OnPauseClicked()
	{
		Time.timeScale = 0;
		HUDCanvas.GetComponent<GraphicRaycaster> ().enabled = false;
		PauseCanvas.gameObject.SetActive (true);
	}

	public void OnResumeClicked()
	{
		PauseCanvas.gameObject.SetActive (false);
		Time.timeScale = 1;
		HUDCanvas.GetComponent<GraphicRaycaster> ().enabled = true;
	}
}
