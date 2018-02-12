using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Music : MonoBehaviour {
    public AudioSource audio;
    public AudioClip select;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (audio.time > 25.849f)
        {
            audio.time = 0.0f; 
        }
        if (Script_PlayButton.gameStart)
        {
            audio.Stop();
            
        }

    }
}
