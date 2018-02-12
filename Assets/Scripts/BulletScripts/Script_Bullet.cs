﻿using UnityEngine;
using System.Collections;

public class Script_Bullet : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		GetComponent<Rigidbody2D>().velocity = transform.right * 15f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
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
