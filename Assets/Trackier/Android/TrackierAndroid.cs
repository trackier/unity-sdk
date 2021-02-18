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
		 AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		 AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
		 AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		 AndroidJavaObject context = activity.Call<AndroidJavaObject>("getApplicationContext");
		 AndroidJavaObject trackierSDKConfig = new AndroidJavaObject("com.trackier.sdk.TrackierSDKConfig",context,appToken,environment);
		 trackierSDK.CallStatic("initialize",trackierSDKConfig);
		}
		catch(System.Exception e)
		{
			Debug.Log("System.Exception: "+e.Message);
		}
	  }
		public static void TrackEvent(TrackierEvent te) {
		try {
		 AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
		 AndroidJavaObject TrackEventClass = new AndroidJavaObject("com.trackier.sdk.TrackierEvent",te.EventId);
		 TrackEventClass.Set("orderId",te.orderId);
		 TrackEventClass.Set("currency",te.currency);
		 TrackEventClass.Set("param1",te.param1);
		 TrackEventClass.Set("param2",te.param2);
		 TrackEventClass.Set("param3",te.param3);
		 TrackEventClass.Set("param4",te.param4);
		 TrackEventClass.Set("param5",te.param5);
		 TrackEventClass.Set("param6",te.param6);
		 TrackEventClass.Set("param7",te.param7);
		 TrackEventClass.Set("param8",te.param8);
		 TrackEventClass.Set("param9",te.param9);
		 TrackEventClass.Set("param10",te.param10);
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



