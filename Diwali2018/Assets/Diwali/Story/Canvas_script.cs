using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_script : MonoBehaviour {

    public Canvas c, c1, c2, c3, c4;
	// Use this for initialization
	void Start () {
        c.enabled = true;
        c1.enabled = false;
        c2.enabled = false;
        c3.enabled = false;
        c4.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Btn_click_left()
    {
        if(c.enabled==true)
        {
            Application.LoadLevel("Menu");
        }
        else if (c1.enabled == true)
        {
            c.enabled = true;
            c1.enabled = false;
        }
        else if (c2.enabled == true)
        {
            c1.enabled = true;
            c2.enabled = false;
        }
        else if (c3.enabled == true)
        {
            c2.enabled = true;
            c3.enabled = false;
        }
        else if (c4.enabled == true)
        {
            c3.enabled = true;
            c4.enabled = false;
        }




    }
    public void Btn_click_right()
    {
        if (c.enabled == true)
        {
            c.enabled = false;
            c1.enabled = true;
        }
        else if (c1.enabled == true)
        {
            c1.enabled = false;
            c2.enabled = true;
        }
        else if (c2.enabled == true)
        {
            c2.enabled = false;
            c3.enabled = true;
        }
        else if (c3.enabled == true)
        {
            c3.enabled = false;
            c4.enabled = true;
        }
        else if (c4.enabled == true)
        {
            Application.LoadLevel("Menu");
        }




    }
}
