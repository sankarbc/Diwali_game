﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour {
    public Canvas show_up;
    public Canvas show_down;
    public GameObject nilaa;
   
   
 
    void Start () {
        show_up.enabled = true;
        show_down.enabled = false;
        nilaa.SetActive(false);


    }
	
	public void show()
    {
       

       // string s = gameObject.transform.name;
        if (nilaa.name=="nila")
        {
           
            show_down.enabled = true;
            nilaa.SetActive(true);
           
           
        }
        
    }
}
