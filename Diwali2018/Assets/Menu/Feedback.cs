using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Feedback : MonoBehaviour {

   public InputField email,feed_back;
   public Canvas feed_canvas;
	  void Start () {
  		 feed_canvas.enabled=false;   
     }
 
 
 
     IEnumerator WaitForRequest(WWW www)
     {
         yield return www;
 
         // check for errors
         if (www.error == null)
         {
             Debug.Log("WWW Ok!: " + www.text);
         } else {
             Debug.Log("WWW Error: "+ www.error);
         }    
     }   
	 
	 public void feedclick(){
		 email.text="Email..";
  feed_back.text="Feedback..";
  
		 feed_canvas.enabled=true;
		 
	 }
	 
	 public void feedcancel(){
		 
		 		 feed_canvas.enabled=false;

	 }

public void send(string url){
	 
	  WWWForm form = new WWWForm();
         form.AddField("type", "diwali");
         form.AddField("feedback", ""+feed_back.text);
        form.AddField("email", ""+email.text);
    form.AddField("vcode", "1.0");
	form.AddField("model", "model");

	     WWW www = new WWW(url, form);
         StartCoroutine(WaitForRequest(www));
		 		 feed_canvas.enabled=false;

	 
 }	 
}
