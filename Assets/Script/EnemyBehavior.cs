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
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Wall" && col.gameObject.transform.parent.transform.parent.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsTag ("Smasher").Equals (true)) 
		{
			speed = 0;
			GetComponent<Animator> ().SetTrigger ("Smashed");
			Invoke ("Destroyer", 1.7f);
		}
		else if(col.gameObject.tag == "Wall" && col.gameObject.transform.parent.transform.parent.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsTag ("Smasher").Equals (false)) 
		{
			speed = 0;
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Wall" && col.gameObject.transform.parent.transform.parent.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsTag ("Smasher").Equals (false) && GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsTag ("Smashed").Equals (false))
		{
			speed = 1;
		}
	}

	public void Destroyer()
	{
		Destroy (this.gameObject);
	}

}
