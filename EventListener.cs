using UnityEngine;
using System.Collections;

public class EventListener : MonoBehaviour {

    //3
    //subscribe using built in unity function
    void OnEnable()
    {
        //we can call our defined event. Lighting bolt for events.
        //+= is a subscription
        EventManager.OnPoweredUp += onPoweredUp;
    }

    //unsubscribe
	void OnDisable () 
    {
        EventManager.OnPoweredUp -= onPoweredUp;
	}

    //2 we need the boolean argument first
	void onPoweredUp (bool isPoweredUp) 
    {
        //the real meat goes here
        Debug.Log(isPoweredUp);
	}
}
