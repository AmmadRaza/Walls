using UnityEngine;
using System.Collections;

public class powerup : MonoBehaviour {

	public GameObject m_button;
	public GameObject fire;



	public void SetPowerUp()
	{
		fire.SetActive(true);
		m_button.SetActive(false);
	}
}
