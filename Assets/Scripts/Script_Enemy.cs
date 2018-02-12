using UnityEngine;
using System.Collections;

public class Script_Enemy : MonoBehaviour {

	public float speed;
	public float bulletTimer;
	public float enemy_nextFire;
	public int enemyHealth;
	public bool shoot = true;
	public static bool shooting = false;
	public static int energyAdd;

	//public GameObject player;
	public GameObject enemyBullet;
	public AudioClip deathSFX;
	public AudioSource shootSFX;
	public GameObject deathParticle;


	// Use this for initialization
	void Start () 	
	{
		//get script from player object
		//Script_Player targetScript = player.GetComponent<Script_Player> ();
		GetComponent<Rigidbody2D> ().velocity = transform.right * speed;
		enemy_nextFire = Time.time + bulletTimer;
		StartCoroutine ("Shoot");
	}
	
	// Update is called once per frame
	void Update () 	
	{
			
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.CompareTag("AccelerationStop"))
		{
			GetComponent<Rigidbody2D> ().velocity = transform.right * -2;
		}
		if(other.gameObject.CompareTag("KillboxLeft"))
		{
			Destroy (gameObject);
		}
		if (other.gameObject.CompareTag ("PulseBullet"))
		{
			energyAdd = 5;
			enemyHealth -= 25;
			StartCoroutine ("Hurt");
		}
		if (other.gameObject.CompareTag ("GatlingBullet"))
		{
			energyAdd = 1;
			enemyHealth -= 10;
			StartCoroutine ("Hurt");
		}
		if (other.gameObject.CompareTag ("ScatterBullet"))
		{
			energyAdd = 2;
			enemyHealth -= 25;
			StartCoroutine ("Hurt");
		}
		if (other.gameObject.CompareTag ("Player"))
		{
			enemyHealth = 0;
		}
		if (enemyHealth <= 0) 
		{
			Destroy (gameObject);
			Instantiate (deathParticle, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			AudioSource.PlayClipAtPoint (deathSFX, transform.position);
		}
		if (other.gameObject.CompareTag ("ShootStop")) 
		{
			shoot = false;
		}
	}

	public IEnumerator Shoot()
	{
		yield return new WaitForSeconds (1.5f);
		while(shoot)
		{
			//if (Script_Player.playerAlive)
			//{
				shooting = true;
				Instantiate (enemyBullet, new Vector3 (transform.position.x, transform.position.y - 0.3f, 0.1f), Quaternion.identity);
				//yield return new WaitForSeconds (0.0001f);
				//shooting = false;
				yield return new WaitForSeconds (1.5f);
			//}
		}
	}

	public IEnumerator Hurt()
	{
		SpriteRenderer colour = GetComponent<SpriteRenderer>();
		colour.color = new Color (0.5f, 0.5f, 0.5f, 1f);	
		yield return new WaitForSeconds (0.1f);
		colour.color = new Color (1f, 1f, 1f, 1f);	
	}
}
