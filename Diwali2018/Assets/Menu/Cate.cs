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
    public void cracker()
    {
        Application.LoadLevel("cracker1");
    }
    public void firework()
    {
        Application.LoadLevel("cracker2");
    }
}
