using UnityEngine;
using System.Collections;
enum TouchEvent
{
	TouchIn =0,
	TouchOut =1,
	Touchnull =2
};
public class QQ : MonoBehaviour {

	public float speed = 0.1F;  
	bool bIsTouch=false;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		TouchEvent myTouchEvent = IsFirstHit ();
		if (TouchEvent.TouchIn == myTouchEvent) 
		{
			TouchInEvent();
		}
		else if(TouchEvent.TouchOut == myTouchEvent)
		{
			TouchOutEvent();
		}
	}
	void TouchInEvent()
	{
		transform.Translate(0, -2, 0);
	}
	void TouchOutEvent()
	{
		transform.Translate(0, 2, 0);
	}



	//***************************************jasontjzhu*****************************
	//2015.08.02
	TouchEvent IsFirstHit()
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Stationary) 
		{
			
			if(bIsTouch==false)
			{
				bIsTouch=true;
				return TouchEvent.TouchIn;
			}
		}
		else if( Input.touchCount <= 0 )
		{
			if(bIsTouch==true)
			{
				bIsTouch=false;
				return TouchEvent.TouchOut;
			}
		}
		return TouchEvent.Touchnull;
	}
	//***************************************jasontjzhu*****************************
}
