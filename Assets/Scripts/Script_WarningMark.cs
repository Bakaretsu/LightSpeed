using UnityEngine;
using System.Collections;

public class Script_WarningMark : MonoBehaviour {
	public GameObject warningMark;
	public AudioSource warningSfx;
	public AudioSource wooshSFX;

	// Use this for initialization
	void Start () {
		StartCoroutine ("warningFlash");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator warningFlash()
	{
		for (int i = 0; i < 3; i++) 
		{
			
			warningMark.GetComponent<SpriteRenderer> ().enabled = false;
			yield return new WaitForSeconds (0.1f);
			if (Script_Player.playerAlive) 
			{
				warningSfx.Play ();
			}
			warningMark.GetComponent<SpriteRenderer> ().enabled = true;
			yield return new WaitForSeconds (0.1f);
			//yield return new WaitForSeconds (0.1f);
			//
		}
		warningMark.GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (0.2f);
		if (Script_Player.playerAlive) 
		{
			wooshSFX.Play ();
		}

		yield return new WaitForSeconds (2f);
		Destroy (gameObject);
	}
}
