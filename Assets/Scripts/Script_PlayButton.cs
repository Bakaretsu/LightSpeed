using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_PlayButton : MonoBehaviour {
    public static bool gameStart = false;
    public AudioSource start;
    //public static bool titleScreen = true;

    public GameObject title;
    public GameObject playButton;
    public GameObject instructionsButton;
    public GameObject backButton;
    public GameObject instructions;
    // Use this for initialization
    void Start () {
        SpriteRenderer colour = GetComponent<SpriteRenderer>();
        colour.color = new Color(1f, 1f, 1f, 0f);
        backButton.SetActive(false);
        instructions.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadScene(string name)
    {
        start.Play();
        gameStart = true;
        StartCoroutine(name);
        
    }

    public IEnumerator Fade()
    {
        SpriteRenderer colour = GetComponent<SpriteRenderer>();
        yield return new WaitForSeconds(1f);
        for (float i = 0f; i <= 1.1f; i += 0.1f)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(0.1f);
            colour.color = new Color(1f, 1f, 1f, i);
        }
        SceneManager.LoadScene("Level_2");
    }

    public void goToInstructions()
    {
        //titleScreen = false;
        playButton.SetActive(false);
        instructionsButton.SetActive(false);
        title.SetActive(false);

        backButton.SetActive(true);
        instructions.SetActive(true);
    }

    public void goToTitle()
    {
        //titleScreen = true;
        playButton.SetActive(true);
        instructionsButton.SetActive(true);
        title.SetActive(true);

        backButton.SetActive(false);
        instructions.SetActive(false);
    }
}
