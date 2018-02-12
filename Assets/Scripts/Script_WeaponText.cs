using UnityEngine;
using System.Collections;

public class Script_WeaponText : MonoBehaviour {

	public float moveSpeed = 2f;

	// Use this for initialization
	void Start () 
	{
		
		StartCoroutine ("TextMove");
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, moveSpeed);
	}

	public IEnumerator TextMove()
	{
		yield return new WaitForSeconds (0.2f);
		for (int i = 0; i < 4; i++) 
		{
			moveSpeed -= 0.5f;
			yield return new WaitForSeconds(0.1f);
		}
		Destroy (gameObject);
	}
}
