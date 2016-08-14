using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour 
{
	public GameObject m_button;
	public AudioSource[] m_audio;
	private float speed;

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

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "enemies" && this.gameObject.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsTag ("Smasher").Equals (true)) 
		{
			speed = col.gameObject.GetComponent<EnemyBehavior> ().speed;
			col.gameObject.GetComponent<EnemyBehavior> ().speed = 0;
			col.gameObject.GetComponent<Animator> ().SetTrigger ("Smashed");
		}
		else 
		{
			speed = col.gameObject.GetComponent<EnemyBehavior> ().speed;
			col.gameObject.GetComponent<EnemyBehavior> ().speed = 0;
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "enemies") 
		{
			col.gameObject.GetComponent<EnemyBehavior> ().speed = 1.5f;
		}
	}
}
