using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.trackier.sdk
  {
    #if UNITY_ANDROID
    public class TrackierAndroid {
         public static void Start(String appToken, String environment) {

            try {

           Debug.Log("trackier initlize unityPlayer");
           AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

           Debug.Log("trackier initlize unityPlayer");
           AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");

           Debug.Log("trackier initlize activity");
           AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

           Debug.Log("trackier initlize context");
           AndroidJavaObject context = activity.Call<AndroidJavaObject>("getApplicationContext");
           
           AndroidJavaObject trackierSDKConfig = new AndroidJavaObject("com.trackier.sdk.TrackierSDKConfig",context,appToken,environment);
           Debug.Log("trackier initlize trackierSDKConfig");
           
           Debug.Log("trackier initlize called");
           trackierSDK.CallStatic("initialize",trackierSDKConfig);
           Debug.Log("trackier initlize finish");


          }
          catch (System.Exception e)
          {
               Debug.Log("System.Exception: "+e.Message);
          }
       }

       public static void EventTrack(String EventID, TrackEvent trackEvent) {

            try {

           Debug.Log("trackier EventTrack unityPlayer");
           AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
       

          //  foreach(KeyValuePair<string, object> kvp in trackEvent.eventValues){
          //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value.ToString());
          //  }

           AndroidJavaObject TrackEventClass = new AndroidJavaObject("com.trackier.sdk.TrackierEvent",EventID);
           TrackEventClass.Set("orderId",trackEvent.orderId);
           TrackEventClass.Set("currency",trackEvent.currency);
           TrackEventClass.Set("param1",trackEvent.param1);
           TrackEventClass.Set("param2",trackEvent.param2);
           TrackEventClass.Set("param3",trackEvent.param3);
           TrackEventClass.Set("param4",trackEvent.param4);
           TrackEventClass.Set("param5",trackEvent.param5);
           TrackEventClass.Set("param6",trackEvent.param6);
           TrackEventClass.Set("param7",trackEvent.param7);
           TrackEventClass.Set("param8",trackEvent.param8);
           TrackEventClass.Set("param9",trackEvent.param9);
           TrackEventClass.Set("param10",trackEvent.param10);
          // TrackEventClass.Set("revenue",trackEvent.revenue);
          // TrackEventClass.Set("ev",AndroidUtil.CreateJavaMapFromDictainary(trackEvent.eventValues));
           
          
           trackierSDK.CallStatic("trackEvent",TrackEventClass);

          }
          catch (System.Exception e)
          {
               Debug.Log("System.Exception: "+e.Message);
          }

       }
    }
  #endif 
}



