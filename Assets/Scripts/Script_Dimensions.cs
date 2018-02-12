using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_Dimensions : MonoBehaviour {

	public Text Dimensions;
	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {
		Dimensions.text = "Height: " + Screen.height.ToString () + "   Width: " + Screen.width.ToString ();
	}
}
