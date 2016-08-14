using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour 
{

    public float speed;
    Vector3 tempPosition;

  
	// Update is called once per frame
	void Update ()
    {
        tempPosition = transform.position;
        tempPosition.y += speed * Time.deltaTime;
        transform.position = tempPosition;
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Wall" && col.gameObject.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsTag ("Smasher").Equals (true))
		{
			Invoke ("Destroyer", 0.5f);
		}
	}

	public void Destroyer()
	{
		Destroy (this.gameObject);
	}

}
