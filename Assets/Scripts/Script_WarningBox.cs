using UnityEngine;
using System.Collections;

public class Script_WarningBox : MonoBehaviour {
	public GameObject warningBox;
	public GameObject warningMark;
	// Use this for initialization
	void Start () 
	{
		Instantiate (warningMark, new Vector3 (transform.position.x, transform.position.y, -2f), Quaternion.identity);
		StartCoroutine ("warningFlash");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator warningFlash()
	{
		yield return new WaitForSeconds (1f);
		warningBox.GetComponent<SpriteRenderer> ().enabled = false;
	}
}
