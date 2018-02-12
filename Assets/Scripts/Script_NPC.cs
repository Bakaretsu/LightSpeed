using UnityEngine;
using System.Collections;

public class Script_NPC : MonoBehaviour {
	public GameObject deathParticle;
	public AudioClip deathSFX;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("EnemySpeeder")) 
		{
			Instantiate (deathParticle, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			AudioSource.PlayClipAtPoint (deathSFX, transform.position);
			Destroy (gameObject);
		}
	}
}
