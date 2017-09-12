using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen : MonoBehaviour {

    public Camera Cam1;
    public Camera Cam2;

    public bool Horizontal = false;

	// Update is called once per frame
	void Start () {
        ChangeSplitScreen();
	}

    public void ChangeSplitScreen()
    {
        Horizontal = !Horizontal;

        if(Horizontal)
        {
            Cam1.rect = new Rect(0f, 0, 1f, 1f);
            Cam2.rect = new Rect(0f, 0.5f, 1f, 0.5f);
        }
        else
        {
            Cam1.rect = new Rect(0, 0, 1f, 1f);
            Cam2.rect = new Rect(0, 0, 1f, 1f);
        }
    }
}
