using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class WaveSystem : MonoBehaviour
{
	// The enemy prefab to be spawned.
	public GameObject[] enemy; 

	// How long between each spawn.
	//public float spawnTime = 3f;            
	public Transform[] spawnPoints;         

	private float timer = 4;


	int index = 0 ;

	int wave = 0;


	private int m_enemyCount = 1;

	void Update()
	{
	//	Debug.Log(spawnTime + "spawTime");
		Debug.Log(timer);


		timer -= Time.deltaTime;

		if (timer <= 0 && wave < 6)
		{
			timer = 2;
			Spawn();

			wave++;

			if (wave != 0 &&  wave % 2 == 0)
			{
				index ++ ;
			}


		}
	}

	void Spawn ()
	{

		for (int i = 0; i<m_enemyCount;i++)
		{
			InvokeRepeating("EnemySpawner",0,5);
		}
	}

	void EnemySpawner ()
	{
		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		//Create the enemies at a random transform 
		GameObject InstanceEnemies= Instantiate ( enemy[index] , spawnPoints[spawnPointIndex].position , spawnPoints[spawnPointIndex].rotation) as GameObject;


	}


	public 	void LoseCondition (string LoadScene)
	{
		Application.LoadLevel(LoadScene);
	}
}