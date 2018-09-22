using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

     float timeTakenDuringLerp = 3f;
    public float distanceToMove =1;

    //Whether we are currently interpolating or not
    private bool _isLerping;

    //The start and finish positions for the interpolation
    private Vector3 _startPosition;
    private Vector3 _endPosition;

    //The Time.time value when we started the interpolation
    private float _timeStartedLerping;
	public float x,y,z=-3f;
	public float returnx,returny,returnz=-3f;

   Animator animator; 
   
   public static bool stop;
   
   public Sound sound;

    void Start() {

	    animator = this.GetComponent<Animator>();
				stop=true;


      //  StartLerping();

    }
   public void StartLerping()
    {
		stop=false;
		
         timeTakenDuringLerp = 3f;
        _isLerping = true;
        _timeStartedLerping = Time.time;
		sound.play();

        _startPosition = transform.position;
		_endPosition = new Vector3(x,y,z);
		 animator.SetInteger("walk", 1);
		 animator.SetInteger("girl_walk", 1);


    }
	
	 public void StartLerping1()
    {
		

        _timeStartedLerping = Time.time;

        _startPosition = transform.position;
		        _endPosition = new Vector3(returnx,returny,returnz);
						            animator.SetInteger("walk", 3);
								animator.SetInteger("girl_walk",3);

									
								stop=false;

    }
  
    //We do the actual interpolation in FixedUpdate(), since we're dealing with a rigidbody
    void FixedUpdate()
    {
		
        if (_isLerping)
        {

            float timeSinceStarted = Time.time - _timeStartedLerping;
            float percentageComplete = timeSinceStarted / timeTakenDuringLerp;


            transform.position = Vector3.Lerp(_startPosition, _endPosition, percentageComplete);

            //When we've completed the lerp, we set _isLerping to false
			
			if(transform.position.x>=x){

											animator.SetInteger("girl_walk",2);

	
			timeTakenDuringLerp=1.5f;

	        StartCoroutine(boom());
												
			}
			
			if(transform.position.x==returnx){
								           
										    animator.SetInteger("walk",4);
										    animator.SetInteger("girl_walk",4);

											//	x=-2f;
				stop=true;
											_isLerping=false;

																							
			}
           
        }
    }
 IEnumerator boom()
	{

		yield return new WaitForSeconds (2);
		StartLerping1 ();
        
	}


}
