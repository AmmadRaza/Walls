using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class WaveSystem : MonoBehaviour
{
	// The enemy prefab to be spawned.
	public GameObject[] enemy; 

	// How long between each spawn.
	public float spawnTime = 10f;            
	public Transform[] spawnPoints;         

	private float timer = 10;

//	public Text waveText;

	int index = 0 ;

	int wave = 0;

	List <GameObject> EnemiesList = new List<GameObject>();

	private int m_enemyCount = 30;

	void Update()
	{


	//	waveText.text = ("Wave " + wave + "/ 6  " + " Next Wave In  " + timer.ToString("0"));

		timer -= Time.deltaTime;

		if (timer <= 0 && wave < 6)
		{
			timer = 30;

			// In our first 2 waves spawn the default zombie , Changes the enemy every 2 waves.
			if (wave != 0 &&  wave % 2 == 0)
			{
				// Add's up the index of enemies in order to get a differnt enemy.
				index ++ ;
			}

			Spawn();

			// Adds up the number of the waves.
			wave++;
		}
	}

	void Spawn ()
	{

		// Spawn enemies, number of enemies is defined in the enemyCount Integer.
		for (int i = 0; i<m_enemyCount;i++)
		{
			Invoke("EnemySpawner" , i + 2);
		}
	}

	void EnemySpawner ()
	{
		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		//Create the enemies at a random transform 
		GameObject InstanceEnemies= Instantiate ( enemy[index] , spawnPoints[spawnPointIndex].position , spawnPoints[spawnPointIndex].rotation) as GameObject;

		// Create enemies and add them to our list.
		EnemiesList.Add(InstanceEnemies);

	}

	public void Remove (GameObject anything)
	{
		// Remove the enemy from the list when he is destroyed.
		EnemiesList.Remove (anything);
	}

	public 	void LoseCondition (string LoadScene)
	{
		Application.LoadLevel(LoadScene);
	}
}