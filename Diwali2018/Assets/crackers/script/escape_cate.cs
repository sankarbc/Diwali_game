using UnityEngine;
using System.Collections;

public class escape_cate : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.LoadLevel("cate");
        }
    }




}
