using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playPage : MonoBehaviour {
    [SerializeField]
    GameObject PlayPage;
    [SerializeField]
    GameObject ToolContents;
    //[SerializeField]
    //Toggle PlayToggle;

    public void playpage()
    {
        PlayPage.SetActive(true);
        ToolContents.SetActive(false);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
