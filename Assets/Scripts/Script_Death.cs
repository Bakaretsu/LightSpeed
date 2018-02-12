using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Script_Death : MonoBehaviour {
	public bool screenChange = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!Script_Player.playerAlive && screenChange) 
		{
			screenChange = false;
			//StartCouroutine ("LoseScreen");
		}
	}
	//public IEnumerator LoseScreen()
	//{
		//yield return new WaitforSeconds (3f);
	//}
}
