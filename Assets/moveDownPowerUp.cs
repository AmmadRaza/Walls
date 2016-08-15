using UnityEngine;
using System.Collections;

public class moveDownPowerUp : MonoBehaviour 
{
	public float speed =5;

	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.down * speed *Time.deltaTime);
	}

	void OnCollisionEnter(Collision coll) 
	{
		if (coll.gameObject.tag == "enemies")
			Destroy(coll.gameObject);
			Destroy(this.gameObject , 7);
	}
}
