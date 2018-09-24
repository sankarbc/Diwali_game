using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    private RaycastHit hit;
  //  public ParticleSystem burst_particle;
    public float delay_time;
    public GameObject cracker_duplicate;
    public float x, y, z;
    // Use this for initialization
    void Start()
    {

    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
           
                GameObject cracker_duplicate1 = Instantiate(cracker_duplicate, new Vector3(x, y, z), Quaternion.identity) as GameObject;
            
        }
    }
}
