using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM : MonoBehaviour {
    [SerializeField]Toggle MusicOn;
    [SerializeField]Toggle MusicOff;

    public AudioSource audiosource;
    public void musicOn()
    {
        audiosource.Play();
    }

    public void musicOff()
    {
        audiosource.Stop();
    }

    // Use this for initialization
    void Start () {
        audiosource.Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
