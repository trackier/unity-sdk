using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.trackier.sdk;

public class mainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     TrackierUnity.start("abcf2270-d94a-4364-a2ae-34903c6e1d53");
        
 //abcf2270-d94a-4364-a2ae-34903c6e1d53 tictoctoe
            /* Event Track */
            TrackierEvent trackierEvent = new TrackierEvent("Q4YsqBKnzZ");
            trackierEvent.param1 = "param";
            trackierEvent.currency = "INR";
            TrackierUnity.TrackEvent(trackierEvent);

            Debug.Log("Hi, This is the Unity App");     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
