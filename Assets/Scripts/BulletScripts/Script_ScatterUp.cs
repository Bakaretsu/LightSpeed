using UnityEngine;
using System.Collections;

public class Script_ScatterUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2 (15f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("KillboxRight")) 
		{
			Destroy (gameObject);

		}

		if (other.gameObject.CompareTag ("Enemy")) 
		{
			Destroy (gameObject);

		}
	}
}
