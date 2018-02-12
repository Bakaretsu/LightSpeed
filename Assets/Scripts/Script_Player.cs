using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Script_Player : MonoBehaviour {
	private Rigidbody2D Rb_player;
	public float moveSpeed;

	public float fireRate = 0.5f;
	public float nextFire = 0f;
	public static bool playerAlive = true;

	public GameObject sliderFill;
	public Slider healthSlider;
	public float playerHealth = 100;

	public GameObject EsliderFill;
	public Slider energySlider;
	public float playerEnergy = 0;

	public Sprite playerBase, playerGatling, playerBasic, playerShotgun;
	public GameObject gatlingText;
	public GameObject scatterText;
	public GameObject pulseText;

	private int weaponNum = 0;
	private bool canFire = true;
	public GameObject pulseBullet;
	public GameObject gatlingBullet;
	public GameObject scatterBullet;
	public GameObject scatterBulletUp;
	public GameObject scatterBulletDown;

	public AudioSource weaponSwitch;
	public AudioSource pulseShoot;
	public AudioSource gatlingShoot;
	public AudioSource scatterShoot;
	public AudioSource heal;

	public int damage;

	public GameObject playerHurt;
	public GameObject playerDeath;

	public AudioSource playerHurtSFX;
	public AudioClip playerDeathSFX;

	// Use this for initialization
	void Start () 
	{
		playerAlive = true;
		Rb_player = GetComponent<Rigidbody2D> ();
		sliderFill.GetComponent<Image> ().color = new Color (1f, 0f, 0f, 1f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < -4.5f)
		{
			transform.position = new Vector2 (transform.position.x, -4.5f);
		}
		else if (transform.position.y > 2.25f)
		{
			transform.position = new Vector2 (transform.position.x, 2.25f);
		}

		if (transform.position.x < -7.9f)
		{
			transform.position = new Vector2 (-7.9f, transform.position.y);
		}
		else if (transform.position.x > 7.9f)
		{
			transform.position = new Vector2 (7.9f, transform.position.y);
		}

		if (Input.GetKey (KeyCode.Z) && canFire && !Script_TextBox.textActive)
		{
			if (weaponNum == 1) 
			{
				//create bullet
				Instantiate (pulseBullet, new Vector3 (transform.position.x + 0.6f, transform.position.y - 0.2f, 0.1f), Quaternion.identity);
				//play SFX
				pulseShoot.Play ();
			}
			if (weaponNum == 2) 
			{
				//create bullet
				Instantiate (gatlingBullet, new Vector3 (transform.position.x + 0.5f, transform.position.y - 0.2f, 0.1f), Quaternion.identity);
				//play SFX
				gatlingShoot.Play ();
			}
			if (weaponNum == 3) 
			{
				//create bullets
				Instantiate (scatterBullet, new Vector3 (transform.position.x + 0.5f, transform.position.y - 0.2f, 0.1f), Quaternion.identity);
				Instantiate (scatterBulletUp, new Vector3 (transform.position.x + 0.5f, transform.position.y - 0.2f, 0.1f), Quaternion.identity);
				Instantiate (scatterBulletDown, new Vector3 (transform.position.x + 0.5f, transform.position.y - 0.2f, 0.1f), Quaternion.identity);
				//play SFX
				scatterShoot.Play ();
			}
			canFire = false;

			StartCoroutine ("Reload");
		}

		if (!Script_TextBox.textActive) 
		{
			if(Input.GetKeyDown (KeyCode.Alpha1))
			{
				if (weaponNum != 1)
				{
					//change sprite to correspond to weapon
					this.gameObject.GetComponent<SpriteRenderer>().sprite = playerBasic;
					//create text that displays player's new weapon
					Instantiate (pulseText, new Vector3 (transform.position.x, transform.position.y, -1f), Quaternion.identity);
					weaponNum = 1;
					weaponSwitch.Play ();
				}
			}
			if(Input.GetKeyDown (KeyCode.Alpha2))
			{
				if (weaponNum != 2) 
				{
					//change sprite to correspond to weapon
					this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerGatling;
					//create text that displays player's new weapon
					Instantiate (gatlingText, new Vector3 (transform.position.x, transform.position.y, -1f), Quaternion.identity);
					weaponNum = 2;	
					weaponSwitch.Play ();
				}
			}
			if(Input.GetKeyDown (KeyCode.Alpha3))
			{
				if (weaponNum != 3) 
				{
					//change sprite to correspond to weapon
					this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerShotgun;
					//create text that displays player's new weapon
					Instantiate (scatterText, new Vector3 (transform.position.x, transform.position.y, -1f), Quaternion.identity);
					weaponNum = 3;
					weaponSwitch.Play ();
				}
			}
			if (Input.GetKeyDown (KeyCode.C) && playerEnergy >= 25 && playerHealth <= 100) 
			{
				playerHealth += 20;
				playerEnergy -= 25;
				energySlider.value = playerEnergy;
				healthSlider.value = playerHealth;
				heal.Play ();
			}
		}
		if (Script_Enemy.energyAdd > 0 || Script_GatlingEnemy.energyAdd > 0) 
		{
			if (playerEnergy < 100) 
			{
				playerEnergy += Script_Enemy.energyAdd + Script_GatlingEnemy.energyAdd;
				Script_Enemy.energyAdd = 0;
				Script_GatlingEnemy.energyAdd = 0;
				Debug.Log (playerEnergy);
				energySlider.value = playerEnergy;
			}
		}
	}

	void FixedUpdate()
	{
		if (!Script_TextBox.textActive) 
		{
			float moveHor = Input.GetAxis ("Horizontal");
			float moveVer = Input.GetAxis ("Vertical");

			var movement = new Vector2 (moveHor, moveVer);

			Rb_player.velocity = movement * moveSpeed;
		} 
		else 
		{
			Rb_player.velocity = new Vector2 (0f, 0f);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("EnemyBullet"))
		{
			//playerAlive = false;
			damage = 10;
			StartCoroutine ("decreaseHealth");
			StartCoroutine ("Hurt");

		}
		if (other.gameObject.CompareTag ("EnemySpeeder"))
		{
			//playerAlive = false;
			damage = 30;
			StartCoroutine ("decreaseHealth");
			StartCoroutine ("Hurt");
		}	
		if (other.gameObject.CompareTag ("EnemyGatlingBullet"))
		{
			//playerAlive = false;
			damage = 5;
			StartCoroutine ("decreaseHealth");
			StartCoroutine ("Hurt");
		}	
		if (other.gameObject.CompareTag ("Enemy"))
		{
			//playerAlive = false;
			damage = 50;
			StartCoroutine ("decreaseHealth");
			StartCoroutine ("Hurt");
		}	

			//Destroy (gameObject);

	}

	public IEnumerator decreaseHealth()
	{		
		if (damage >= playerHealth) 
		{
			//AudioSource.PlayClipAtPoint (playerDeathSFX, transform.position);
			Instantiate (playerDeath, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			gameObject.SetActive (false);
			playerAlive = false;
			healthSlider.value = 0;
		} else 
		{
			playerHurtSFX.Play ();
			Instantiate (playerHurt, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			sliderFill.GetComponent<Image> ().color = new Color (0.5f, 0.5f, 0.5f, 1f);
			for (int i = 0; i <= damage; i++) 
			{
				playerHealth = playerHealth - 1f;
				healthSlider.value = playerHealth;
				yield return new WaitForSeconds (0.0001f);
			}
			sliderFill.GetComponent<Image> ().color = new Color (1f, 0f, 0f, 1f);
		}
	}

	public IEnumerator Hurt()
	{
		SpriteRenderer colour = GetComponent<SpriteRenderer>();
		colour.color = new Color (0.5f, 0.5f, 0.5f, 1f);	
		yield return new WaitForSeconds (0.1f);
		colour.color = new Color (1f, 1f, 1f, 1f);	
	}

	public IEnumerator Reload()
	{
		if (weaponNum == 1) 
		{
			yield return new WaitForSeconds (0.4f);
		}
		if (weaponNum == 2) 
		{
			yield return new WaitForSeconds (0.1f);
		}
		if (weaponNum == 3) 
		{
			yield return new WaitForSeconds (1f);
		}
		canFire = true;
	}
}
