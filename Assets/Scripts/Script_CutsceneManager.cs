using UnityEngine;
using System.Collections;

public class Script_CutsceneManager : MonoBehaviour {
	public GameObject cutsceneDrone;
	bool spawnDrone = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Script_TextBox.currentLine == 11) 
		{
			if (spawnDrone) 
			{
				Instantiate (cutsceneDrone, new Vector3 (-9.58f, 2.82f, 1f), Quaternion.identity);
				Debug.Log ("Drone Incoming");
				spawnDrone = false;
			}

		}
	}
}
