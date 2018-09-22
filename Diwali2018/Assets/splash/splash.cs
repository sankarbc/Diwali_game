using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splash : MonoBehaviour {
    private void Start()
    {
        



        StartCoroutine("Wait");
        
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(11);

        Application.LoadLevel("Menu");
    }
}

