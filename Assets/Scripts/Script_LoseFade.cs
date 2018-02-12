using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Script_LoseFade : MonoBehaviour {
	public static bool fading = true;
	public AudioSource selectSFX;
	// Use this for initialization
	void Start () 
	{
		fading = true;
	}	
	
	// Update is called once per frame
	void Update () 
	{
		if (fading)
		{
			fading = false;
			Debug.Log ("fade");
			StartCoroutine ("Fade");
		}

		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			selectSFX.Play();
			Debug.Log ("Fade");
			StartCoroutine ("FadeBack");
		}
	}

	public IEnumerator Fade()
	{
		SpriteRenderer colour = GetComponent<SpriteRenderer>();
		colour.color = new Color (0.5f, 0.5f, 0.5f, 1f);	
		for (float i = 1f; i >= 0f; i -= 0.1f) 
		{
			yield return new WaitForSeconds (0.1f);
			colour.color = new Color (1f, 1f, 1f, i);
		}
	}
	public IEnumerator FadeBack()
	{
		SpriteRenderer colour = GetComponent<SpriteRenderer>();
		for (float i = 0f; i <= 1.1f; i += 0.1f) 
		{
			Debug.Log (i);
			yield return new WaitForSeconds (0.1f);
			colour.color = new Color (1f, 1f, 1f, i);
		}
		SceneManager.LoadScene ("Level_2");
	}
}
