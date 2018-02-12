using UnityEngine;
using System.Collections;

public class Script_Sound : MonoBehaviour {

	public AudioSource musicSourceIntro;
	public AudioSource musicSource;
	// Use this for initialization
	void Start () 
	{
		musicSourceIntro.Play ();
		StartCoroutine ("Music");
	}
		

	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator Music()
	{
		yield return new WaitForSeconds (9.959f);
		//yield return new WaitForSeconds (7.237f);
		musicSource.Play ();
	}
}
