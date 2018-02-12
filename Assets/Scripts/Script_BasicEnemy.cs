using UnityEngine;
using System.Collections;

public class Script_BasicEnemy : MonoBehaviour {
	public int enemyHealth;
	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody2D>().velocity = transform.right * -10f;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("PulseBullet"))
		{
			enemyHealth -= 25;
		}
		if (other.gameObject.CompareTag ("GatlingBullet"))
		{
			enemyHealth -= 10;
		}
		if (other.gameObject.CompareTag ("ScatterBullet"))
		{
			enemyHealth -= 25;
		}
		if (enemyHealth <= 0) 
		{
			Destroy (gameObject);
		}
	}
}
