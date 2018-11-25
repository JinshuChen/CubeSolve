using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlertViewOptions
{
    public string cancelButtonTitle;
    public System.Action cancelButtonDelegate;
    public string okButtonTitle;
    public System.Action okButtonDelegate;
}

public class AlertViewController : ViewController
{
    [SerializeField] Text titleLabel;
    [SerializeField] Text messageLabel;
    [SerializeField] Text cancelButtonLabel;
    [SerializeField] Button cancelButton;
    [SerializeField] Button okButton;
    [SerializeField] Text okButtonLabel;
    [SerializeField] GameObject CancelToPage;
    [SerializeField] GameObject CancelPage;


    private static GameObject prefab = null;
    private System.Action cancelButtonDelegate;

    private System.Action okButtonDelegate;

    public static AlertViewController Show(string title, string message, AlertViewOptions options=null)
    {
        if(prefab == null)
        {
            prefab = Resources.Load("Alert View") as GameObject;
        }
        GameObject obj = Instantiate(prefab) as GameObject;
        AlertViewController alertView = obj.GetComponent<AlertViewController>();
        alertView.UpdateContent(title, message, options);
        return alertView;
    }

    public void UpdateContent(string title, string message, AlertViewOptions options=null)
    {
        titleLabel.text = title;
        messageLabel.text = message;

        if(options != null)
        {
            cancelButton.transform.parent.gameObject.SetActive(options.cancelButtonTitle != null || options.okButtonTitle != null);
            cancelButton.gameObject.SetActive(options.cancelButtonTitle != null);
            cancelButtonLabel.text = options.cancelButtonTitle ?? "";
            cancelButtonDelegate = options.cancelButtonDelegate;

            okButton.gameObject.SetActive(options.okButtonTitle != null);
            okButtonLabel.text = options.okButtonTitle ?? "";
            okButtonDelegate = options.okButtonDelegate;
        }
        else
        {
            cancelButton.gameObject.SetActive(false);
            okButton.gameObject.SetActive(true);
            okButtonLabel.text = "OK";
        }
    }

    public void Dismiss()
    {
        Destroy(gameObject);
    }

    public void OnPressCancelButton()
    {
        //if(cancelButtonDelegate != null)
        //{
        //    cancelButtonDelegate.Invoke();
        //}
        //Dismiss();
        CancelToPage.SetActive(true);
        CancelPage.SetActive(false);
    }

    public void OnpressOKButton()
    {
        //if(okButtonDelegate != null)
        //{
        //    okButtonDelegate.Invoke();
        //}
        //Dismiss();
        Application.Quit();

    }

    public void Quit()
    {
        Application.Quit();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //OnpressOKButton();
	}
}
