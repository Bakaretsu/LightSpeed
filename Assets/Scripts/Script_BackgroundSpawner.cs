using UnityEngine;
using System.Collections;

public class Script_BackgroundSpawner : MonoBehaviour {
	public GameObject foreGround;
	public GameObject middleGround;
	public GameObject backGround;
	public GameObject sky;

    public bool titlescreen;
	bool spawnFg = true;
	bool spawnMg = true;
	bool spawnBg = true;
	bool spawnSky = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (spawnFg && titlescreen) 
		{
			StartCoroutine ("spawnForeGround");
			spawnFg = false;
		}
		if (spawnMg && titlescreen) 
		{
			StartCoroutine ("spawnMiddleGround");
			spawnMg = false;
		}
		if (spawnBg && titlescreen) 
		{
			StartCoroutine ("spawnBackGround");
			spawnBg = false;
		}
		if (spawnSky) 
		{
			StartCoroutine ("spawnSkies");
			spawnSky = false;
		}
	}

	public IEnumerator spawnForeGround()
	{
		Instantiate (foreGround, new Vector3 (17.81f, -1f, 1f), Quaternion.identity);
		yield return new  WaitForSeconds (1.2f);
		spawnFg = true;
	}

	public IEnumerator spawnMiddleGround()
	{
		Instantiate (middleGround, new Vector3 (17.81f, -0.08f, 5f), Quaternion.identity);
		yield return new  WaitForSeconds (3f);
		spawnMg = true;
	}

	public IEnumerator spawnBackGround()
	{
		Instantiate (backGround, new Vector3 (17.7f, 0f, 10f), Quaternion.identity);
		yield return new  WaitForSeconds (5.5f);
		spawnBg = true;
	}

	public IEnumerator spawnSkies()
	{
		Instantiate (sky, new Vector3 (17f, 0f, 15f), Quaternion.identity);
		yield return new  WaitForSeconds (16.8f);
		spawnSky = true;
	}
}
