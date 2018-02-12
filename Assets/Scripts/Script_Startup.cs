using UnityEngine;
using System.Collections;

public class Script_Startup : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Screen.SetResolution (1280, 720, false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F))
			Screen.fullScreen = !Screen.fullScreen;
	}
}
