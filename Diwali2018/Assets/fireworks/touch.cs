using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour {
    public Canvas show_up;
    public Canvas show_down;
    void Start () {
        show_up.enabled = true;
        show_down.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
