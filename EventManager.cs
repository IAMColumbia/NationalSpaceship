using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour 
{
	//Create a manager that contains events in the scene for subscriptions 

    //1
    public delegate void PowerUpHandler(bool isPoweredUp);

    //We are going to use the type (delegate) to let the compiler know that function that listens should 
    //take a bool param
    //1
    //We will be able to subscribe to this event.
    public static event PowerUpHandler OnPoweredUp;

    //4
	void OnGUI() 
    {
        //Label powerup
	    if (GUI.Button(new Rect(5,5, 150, 40), "Power Up"))
        {
            //delegates will be null if they are not assigned
            if (OnPoweredUp != null)
            {
                //pass true
                OnPoweredUp(true);

            }
        }

        //label power over
        if (GUI.Button(new Rect(5, 50, 150, 40), "Power Up Over"))
        {
            //delegates will be null if they are not subscribed to, so we need to check first
            if (OnPoweredUp != null)
            {
                //pass true
                OnPoweredUp(false);
            }
        }
	}

}

//public class DelegateScript : MonoBehaviour
//{
//    delegate void MyDelegate(int num);
//    MyDelegate myDelegate;


//    void Start()
//    {
//        myDelegate = PrintNum;
//        myDelegate(50);

//        myDelegate = DoubleNum;
//        myDelegate(50);
//    }

//    void PrintNum(int num)
//    {
//        print("Print Num: " + num);
//    }

//    void DoubleNum(int num)
//    {
//        print("Double Num: " + num * 2);
//    }
//}
