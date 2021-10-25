using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.trackier.sdk;

namespace com.sampleapp
{
    public class Script : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

            /* Initialize sdk */
            TrackierUnity.start("xxxx-xx-4505-bc8b-xx");

 
            /* Event Track */
            TrackierEvent trackierEvent = new TrackierEvent("eventId");
            trackierEvent.param1 = "param";
            TrackierUnity.trackierEvent(trackierEvent);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
