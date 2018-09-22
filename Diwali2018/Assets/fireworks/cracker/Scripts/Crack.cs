using UnityEngine;
using System.Collections;

public class Crack : MonoBehaviour {

    public float delay_time;
    public bool isdestroy;
    // public GameObject cracker_duplicate;


    // Use this for initialization
    void Start()
    {

        StartCoroutine(boom());


    }

    // Update is called once per frame
    void Update()
    {


    }

   

    IEnumerator boom()
    {

        yield return new WaitForSeconds(delay_time);
        if (isdestroy)
        {
            Destroy(gameObject);
        }

    }
}
