using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ButtonSound : MonoBehaviour {
    public AudioSource Fx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HoverSound()
    {
        Fx.PlayOneShot(hoverFx);
    }

    public void ClickSound()
    {
        Fx.PlayOneShot(clickFx);
    }
}
