using UnityEngine;
using System.Collections;

public class Script_SpeederEnemyCutscene : MonoBehaviour {
	public int health;
	public Sprite speeder0, speeder1, speeder2, speeder3;
	public AudioSource wooshSFX;
	// Use this for initialization
	void Start () {
		wooshSFX.Play ();
		GetComponent<SpriteRenderer> ().sprite = speeder0;
		GetComponent<Rigidbody2D>().velocity = transform.right * 20f;
		StartCoroutine ("ChangeSprite");

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
	}

	public IEnumerator ChangeSprite()
	{
		for (bool floating = true; floating; floating = true) 
		{
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == speeder0) {
				GetComponent<SpriteRenderer> ().sprite = speeder1;
				yield return new WaitForSeconds (0.1f);
			}
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == speeder1) {
				GetComponent<SpriteRenderer> ().sprite = speeder2;
				yield return new WaitForSeconds (0.1f);
			}
			;
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == speeder2) {
				
				GetComponent<SpriteRenderer> ().sprite = speeder3;
				yield return new WaitForSeconds (0.1f);
			}
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == speeder3) {
				GetComponent<SpriteRenderer> ().sprite = speeder0;
				yield return new WaitForSeconds (0.1f);
			}
		}
	}
}
