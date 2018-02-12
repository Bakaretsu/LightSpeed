using UnityEngine;
using System.Collections;

public class Script_Level1Music : MonoBehaviour {

	public AudioSource stage1Theme;
	public AudioSource shootSFX;
	public AudioSource playerDeathSFX;
	public bool soundPlayed = true;

	// Use this for initialization
	void Start () 
	{
		stage1Theme.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Script_Enemy.shooting && Script_Player.playerAlive) 
		{
			shootSFX.Play ();
			Script_Enemy.shooting = false;
		}
		if (!Script_Player.playerAlive && soundPlayed)
		{
			stage1Theme.Stop ();
			Debug.Log ("play sfx");
			playerDeathSFX.Play ();
			soundPlayed = false;
		}
	}
}
