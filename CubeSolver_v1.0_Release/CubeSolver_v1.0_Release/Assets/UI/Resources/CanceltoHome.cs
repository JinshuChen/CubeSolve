using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanceltoHome : MonoBehaviour
{
    [SerializeField]GameObject CancelPage;

    public void Dismiss()
    {
        Destroy(gameObject);
    }

    public void PressNoButton()
    {
        if (Input.GetKey("escape"))
        {
            Dismiss();
            CancelPage.SetActive(true);
        }

    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    //    if (Input.GetKey("escape"))
      //  {
        //    Application.Quit();

        }
    }
