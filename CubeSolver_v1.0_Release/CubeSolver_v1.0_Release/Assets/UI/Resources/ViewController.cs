using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]

public class ViewController : MonoBehaviour {
    private RectTransform cachedRectTransform;
    public RectTransform CachedRectTransform
    {
        get
        {
            if(cachedRectTransform == null)
            { cachedRectTransform = GetComponent<RectTransform>(); }
            return cachedRectTransform;
        }
    }

    public virtual string Title { get { return ""; }set { } }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
