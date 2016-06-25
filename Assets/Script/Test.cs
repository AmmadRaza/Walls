using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
	public List <GameObject> enemy = new List<GameObject>(); 

	public Transform[] spawnPoints;         

	private float timer = 2;


	int index = 0 ;

	int wave = 0;

	List <GameObject> EnemiesList = new List<GameObject>();

	private int enemyCount=1;


	void Update()
	{
		timer -= Time.deltaTime;

		if (timer <= 0 && wave < 6)
		{
			timer = 3;

			if (wave != 0 &&  wave % 2 == 0)
			{
				index ++ ;
			}

			Spawn();

			wave++;
		}
			
	}

	void Spawn ()
	{

		for (int i = 0; i<enemyCount;i++)
		{
			InvokeRepeating("EnemySpawner" , 2  , 3);
		}
	}

	void EnemySpawner ()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		GameObject InstanceEnemies= Instantiate ( enemy[index] , spawnPoints[spawnPointIndex].position , spawnPoints[spawnPointIndex].rotation) as GameObject;

		EnemiesList.Add(InstanceEnemies);

	}

	public void Remove (GameObject anything)
	{
		EnemiesList.Remove (anything);
	}



}