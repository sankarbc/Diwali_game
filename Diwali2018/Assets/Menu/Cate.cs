using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.LoadLevel("Menu");
        }
    }
    public void fireworks()
    {
        Application.LoadLevel("cracker1");
    }
    public void newfire()
    {
        Application.LoadLevel("cracker2");
    }
    public void wishes()
    {
        Application.LoadLevel("Share_wishes");
    }
    public void kill()
    {
        Application.LoadLevel("naraga");
    }
}
