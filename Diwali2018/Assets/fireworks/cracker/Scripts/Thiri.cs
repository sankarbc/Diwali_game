using UnityEngine;
using System.Collections;

public class Thiri : MonoBehaviour {

    private Animator animator;

    // Use this for initialization
    void Start () {
        animator = this.GetComponent<Animator>();
        animator.SetInteger("fire",0);

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {           
	        StartCoroutine(boom1());
            StartCoroutine(boom());

        }

    }
	
	IEnumerator boom1()
    {

        yield return new WaitForSeconds(5.5f);
            animator.SetInteger("fire", 1);


    }
    IEnumerator boom()
    {

        yield return new WaitForSeconds(10.0f);
        Destroy(gameObject);


    }

}
