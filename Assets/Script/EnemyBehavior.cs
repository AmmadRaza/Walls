﻿using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

    public float speed;
    Vector3 tempPosition;

  
	// Update is called once per frame
	void Update ()
    {
        tempPosition = transform.position;
        tempPosition.y += speed * Time.deltaTime;
        transform.position = tempPosition;
	}


}
