using UnityEngine;
using System.Collections;

public class WallsSpawner : MonoBehaviour 
{
	public GameObject m_wall;
	protected int[] m_xaxis = new int[6], m_zaxis = new int[6];

	// Use this for initialization
	void Start () 
	{
		WallsPositionHolder ();
		
		WallInstantiator ();
	}

	protected void WallInstantiator()
	{
		for (int i = 0; i <= 5; i++) 
		{
			Instantiate (m_wall, new Vector3 (m_xaxis [i], m_wall.transform.position.y, m_zaxis [i]), Quaternion.identity);
		}
	}

	protected void WallsPositionHolder ()
	{
		m_xaxis [0] = -9;
		m_zaxis [0] = -3;

		m_xaxis [1] = 9;
		m_zaxis [1] = -3;

		m_xaxis [2] = 9;
		m_zaxis [2] = 0;

		m_xaxis [3] = -9;
		m_zaxis [3] = 0;

		m_xaxis [4] = -9;
		m_zaxis [4] = 3;

		m_xaxis [5] = 9;
		m_zaxis [5] = 3;
	}

}
