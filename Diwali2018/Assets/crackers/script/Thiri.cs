using UnityEngine;
using System.Collections;

public class Thiri : MonoBehaviour {

    public GameObject thiri;
    private void Start()
    {
        thiri.SetActive(true);
    }
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(boom1());
        }

    }
   
    IEnumerator boom1()
    {
        
        yield return new WaitForSeconds(2);
        thiri.SetActive(false);
    }


   
   

}
