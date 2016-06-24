using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour 
{
	public GameObject m_button;
	public AudioSource[] m_audio;


	void Update()
	{
		if (m_button.GetComponent<SmashScript>().Smasher() == true)
		{
			this.gameObject.GetComponent<Animator> ().SetBool ("WallsAnim", true);
		}
	}

	void SoundEffects()
	{
		m_audio [Random.Range (0, m_audio.Length)].Play ();

	}

	void ResetWalls()
	{
		this.gameObject.GetComponent<Animator> ().SetBool ("WallsAnim", false);
		m_button.GetComponent<SmashScript> ().SetSmasher (false);
	}
}
