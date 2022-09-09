using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.trackier.sdk;

public class mainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TrackierUnity.start("XXXX-d94a-4364-XXX-XXXX");
        TrackierUnity.setUserName("DUMMY");
        TrackierUnity.setUserPhone("123456");

        /* Event Track */
        TrackierEvent trackierEvent = new TrackierEvent(TrackierEvent.PURCHASE);
        trackierEvent.param1 = "param";
        trackierEvent.currency = "INR";
        trackierEvent.couponCode = "test";
        TrackierUnity.TrackEvent(trackierEvent);

        Debug.Log("Hi, This is the Unity App");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
