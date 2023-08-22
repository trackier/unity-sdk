using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.trackier.sdk;

public class mainScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TrackierConfig trackierConfig = new TrackierConfig("e69b921c-bbe8-4419-a1c2-5a9678abffea", "development");
        //TrackierUnity.setUserName("sanu");
        TrackierUnity.setUserPhone("828282782");
        TrackierUnity.setUserEmail("sanu@gmail.com");
        TrackierUnity.setUserId("jhd897439");
        string s = TrackierUnity.getAd();
        TrackierUnity.setUserName(s);
        TrackierUnity.initialize(trackierConfig);

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
