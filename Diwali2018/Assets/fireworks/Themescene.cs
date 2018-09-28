using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Themescene : MonoBehaviour {

	public void Theme1()
    {
        Application.LoadLevel("Theme1");
    }

    public void Theme2()
    {
        Application.LoadLevel("Theme2");
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel("Fire_theme");
        }
    }
}
