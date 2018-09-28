using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitscript1 : MonoBehaviour {
	public Canvas qui;
	// Use this for initialization
	void Start () {
		qui.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
			 
	}
	public void func()
	{
		qui.enabled = true;
	}
}
