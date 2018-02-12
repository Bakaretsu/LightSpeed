using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Script_Cutscenes : MonoBehaviour {
	public GameObject warningBox;
	public static bool deathFade = true;

	// Use this for initialization
	void Start () {
		deathFade = true;
		StartCoroutine ("Warning");
		StartCoroutine ("FadeIn");
		StartCoroutine ("WinTimer");
	}
	
	// Update is called once per frame
	void Update () {	
		if (!Script_Player.playerAlive && deathFade) 
		{
			deathFade = false;
			StartCoroutine ("Fade");
		}
	}

	public IEnumerator Warning()
	{
		yield return new WaitForSeconds (9f);
		Instantiate (warningBox, new Vector2 (0f, 2.22f), Quaternion.identity);
	}

	public IEnumerator Fade()
	{
		SpriteRenderer colour = GetComponent<SpriteRenderer>();
		yield return new WaitForSeconds (2f);
		for (float i = 0f; i <= 1.1f; i += 0.1f) 
		{
			Debug.Log (i);
			yield return new WaitForSeconds (0.1f);
			colour.color = new Color (1f, 1f, 1f, i);
		}
		if (!Script_Player.playerAlive) 
		{
			SceneManager.LoadScene ("LoseScreen");
		} 
		else
		{
			SceneManager.LoadScene ("WinScreen");
		}
	}
	public IEnumerator FadeIn()
	{
		SpriteRenderer colour = GetComponent<SpriteRenderer>();
		colour.color = new Color (0.5f, 0.5f, 0.5f, 1f);	
		for (float i = 1f; i >= -0.1f; i -= 0.1f) 
		{
			yield return new WaitForSeconds (0.1f);
			colour.color = new Color (1f, 1f, 1f, i);
		}
	}

	public IEnumerator WinTimer()
	{
		yield return new WaitForSeconds (106f);
			StartCoroutine ("Fade");
		Debug.Log ("You Win");
	}
}
