using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Script_ReloadOnDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!Script_Player.playerAlive) 
		{
			SceneManager.LoadScene ("Test");
		}
	}
}
