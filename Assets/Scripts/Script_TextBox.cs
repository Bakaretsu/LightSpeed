using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Script_TextBox : MonoBehaviour {

	public GameObject textBox;
	public Text textContent;
	public TextAsset textFile;
	public AudioSource talkSFX;

	public static bool textActive = false;
	public bool doneTalking = false;
	public string[] textLines;
	public float speed;

	public int textNumber = 0;
	public static int currentLine = 0;
	public int endLine;
	public int characterIndex = 0;


	// Use this for initialization
	void Start () 
	{
		if (textFile != null) 
		{
			textLines = (textFile.text.Split ('\n'));
		}

		if (endLine == 0) 
		{
			endLine = textLines.Length - 1;
		}

		StartCoroutine ("writeText");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//textContent.text = textLines[currentLine];

		if (Input.GetKeyDown (KeyCode.Z)) 
		{
			if (characterIndex < textLines [currentLine].Length) 
			{
				characterIndex = textLines [currentLine].Length;
			} 
			else if (currentLine == endLine) 
			{
				textContent.text = " ";
				textBox.SetActive (false);
				textActive = false;
				doneTalking = true;
			}
			else if (currentLine < endLine)
			{
				currentLine++;
				characterIndex = 0;
			}
		}

		if (currentLine > endLine) 
		{
			textBox.SetActive (false);
		}

		if (textNumber == 1 && doneTalking) 
		{
			StartCoroutine ("activateTextBox");
			doneTalking = false;
			Debug.Log ("incoming");
		}
	}

	IEnumerator writeText()
	{
		textNumber++;
		while (textActive) 
		{
			yield return new WaitForSeconds (speed);

			if (characterIndex > textLines [currentLine].Length) 
			{
				continue;
			}	
			textContent.text = textLines [currentLine].Substring (0, characterIndex);
			characterIndex++;
			talkSFX.Play ();
		}
	}

	IEnumerator activateTextBox()
	{
		yield return new WaitForSeconds (3);
		currentLine = 4;
		endLine = 5;
		textActive = true;
		textBox.SetActive (true);
		StartCoroutine ("writeText");
	}
}
