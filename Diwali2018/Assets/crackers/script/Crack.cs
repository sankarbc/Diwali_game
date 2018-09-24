using UnityEngine;
using System.Collections;

public class Crack : MonoBehaviour {

    public float delay_time;
   
    // public GameObject cracker_duplicate;


    // Use this for initialization
    void Start()
    {

        StartCoroutine(boom());


    }

    IEnumerator boom()
    {

        yield return new WaitForSeconds(delay_time);
        
            Destroy(gameObject);
        

    }
}
