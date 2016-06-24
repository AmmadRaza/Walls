using UnityEngine;
using System.Collections;

public class SmashScript : MonoBehaviour 
{
	private bool m_smasher;

	public SmashScript()
	{
		m_smasher = false;
	}

	public bool Smasher()
	{
		return m_smasher;
	}

	public bool SetSmasher( bool a_smasher)
	{
		return m_smasher = a_smasher;
	}

	// an event that will allow player to smash enemies
	public void SmashingEvent()
	{
		m_smasher = true;
	}
}
