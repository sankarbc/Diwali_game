using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    public Canvas setting;
    int get = 0;
   
	void Start () {
        setting.enabled = false;
     
    }
    

    public void set()
    {
        if (get == 0)
        {
           
        
            setting.enabled = true;
            get = 1;
        }
        else if(get==1)
        {
            get = 0;
            setting.enabled = false;
          
        } 
          
        
       
      
    }
    public void next_Scene() 
    {
        Application.LoadLevel("cate");
    }

    public void story_Scene()
    {
        Application.LoadLevel("story");
    }


}
