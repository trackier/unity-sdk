using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.trackier.sdk;
using UnityEngine.UI;

namespace com.trackier.sdk
{

    public class ExampleScript : MonoBehaviour
    {
        // Start is called before the first frame update

        void Start()
        {

            TrackierUnity.start("693927f2-fa54-44db-b31e-3f992a86a897");

            Button btn = GameObject.Find("TrackButton").GetComponent<Button>();
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => TaskOnClick());

        }

        void TaskOnClick()
        {
            // Debug.Log("You have clicked the button!");
            // TrackierEvent te = new TrackierEvent(TrackierEvent.UPDATE);
            // te.param1 = "MY Param";
            // TrackierUnity.TrackEvent(te);
            // Debug.Log(" TrackierUnity.TrackEvent te");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


