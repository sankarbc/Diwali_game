using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fireworks_Exit : MonoBehaviour {


   // public GameObject gameObject;
    // Use this for initialization
    void Start () {
       // gameObject.SetActive(true);
		
	}

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape)) ;
          //  Exit();
    }


    public void Exit()
    {
        Application.LoadLevel("splash");
    }
}
