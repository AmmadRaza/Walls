using UnityEngine;
using System.Collections;

public class SpawnSystem : MonoBehaviour {

	public GameObject EasyEnemey;
	public GameObject MediumEnemey;
	public GameObject HardEnemey;
	public Transform[] SpawnPoints;
	public float TimeBetweenEachSpawns;
	public int NumberOfEasyEnemiesToSpawn;
	public int NumberOfMediumEnemiesToSpawn;
	public float EasyPercentage;
	public float MediumPercentage;
	public float HardPercentage;


	private int waveNumber;
	private float spawnTimer;
	private int numberOfEasyEnemies;
	private int numberOfMediumEnemies;
	// Use this for initialization
	void Start()
	{
		this.spawnTimer = 0.0f;
		this.waveNumber = 0;

	}

	// Update is called once per frame
	void Update()
	{
		this.spawnTimer -= Time.deltaTime;
		if(this.spawnTimer<=0.0f)
		{
			// spawn at a random position 
			Transform spawnPoint = this.SpawnPoints[Random.Range(0, this.SpawnPoints.Length)];
			Vector3 spawnPos = spawnPoint.position;
			Quaternion spawnRot = spawnPoint.rotation;

			// Switch case to spawn between easy , medium and hard enemies.
			switch(this.waveNumber)
			{
			case 0:
				Instantiate(EasyEnemey, spawnPos,spawnRot);
				this.numberOfEasyEnemies++;
				if(this.numberOfEasyEnemies>=this.NumberOfEasyEnemiesToSpawn)
				{
					this.waveNumber++;
				}
				break;
			case 1:
				Instantiate(MediumEnemey, spawnPos, spawnRot);
				this.numberOfMediumEnemies++;
				if (this.numberOfMediumEnemies >= this.NumberOfMediumEnemiesToSpawn)
				{
					this.waveNumber++;
				}
				break;
			case 2:

				// Create a percentage (100%) and give a percentage of enemies
				float randomFloat = Random.value;
				if(randomFloat<this.EasyPercentage)
				{
					Instantiate(EasyEnemey, spawnPos, spawnRot);
				}
				else if(randomFloat<this.EasyPercentage+this.MediumPercentage)
				{
					Instantiate(MediumEnemey, spawnPos, spawnRot);
				}
				else
				{
					Instantiate(HardEnemey, spawnPos, spawnRot);
				}
				break;
			}
			this.spawnTimer = this.TimeBetweenEachSpawns;
		}

	}

}
