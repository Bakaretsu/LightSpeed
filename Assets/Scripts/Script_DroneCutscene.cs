using UnityEngine;
using System.Collections;

public class Script_DroneCutscene : MonoBehaviour {


	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody2D> ().velocity = transform.right * 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("DroneStop"))
		{
			StartCoroutine ("DroneFloat");
		}

		if (other.gameObject.CompareTag ("Player"))
		{
			Destroy (gameObject);
		}
	}
	public IEnumerator DroneFloat()
	{
		for (bool floating = true; floating; floating = true)
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0.1f);
			yield return new WaitForSeconds (1f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, -0.1f);
			yield return new WaitForSeconds (1f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0.1f);
		}
	}
}
