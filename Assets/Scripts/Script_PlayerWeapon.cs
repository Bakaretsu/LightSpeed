using UnityEngine;
using System.Collections;

public class Script_PlayerWeapon: MonoBehaviour {
	public GameObject player;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector2 (player.transform.position.x + 0.6f, player.transform.position.y - 0.3f);
	}
}
