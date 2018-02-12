using UnityEngine;
using System.Collections;

public class Script_EnemyBullet_PlayerDirection : MonoBehaviour {

	public int bulletSpeed;
	// Use this for initialization
	void Start () 
	{
		GameObject player = GameObject.Find ("Prf_Player");
		Vector2 dir = player.transform.position - transform.position;
		dir = dir.normalized;
		GetComponent<Rigidbody2D> ().velocity = dir * bulletSpeed;
	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < -6f)
		{
			Destroy (gameObject);
		}
		else if (transform.position.y > 6f)
		{
			Destroy (gameObject);
		}

		if (transform.position.x < -9f)
		{
			Destroy (gameObject);
		}
		else if (transform.position.x > 9f)
		{
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
		}
	}
}
