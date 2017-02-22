using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public RawImage WASD;
    public RawImage mouse;
    public Text title;

    public Vector3 initialMousePosition;

    // Use this for initialization
    void Start () {

	}

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

        if (Input.GetKey("w"))
        {
            WASD.CrossFadeAlpha(0, .5f, false);
            mouse.CrossFadeAlpha(0, .5f, false);
            title.CrossFadeAlpha(0, .5f, false);
        }
    }
}
