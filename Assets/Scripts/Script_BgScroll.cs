using UnityEngine;
using System.Collections;

public class Script_BgScroll : MonoBehaviour {
	public float scrollSpeed;
	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody2D>().velocity = transform.right * scrollSpeed;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("KillboxLeft")) 
		{
			Destroy (gameObject);
		}
	}
}
