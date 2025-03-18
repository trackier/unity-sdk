using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Analytics;

namespace com.trackier.sdk
{
#if UNITY_ANDROID
    public class TrackierAndroid
    {
        public static void Start(string appToken, string environment)
        {
            try
            {
                AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                AndroidJavaObject context = activity.Call<AndroidJavaObject>("getApplicationContext");
                AndroidJavaObject trackierSDKConfig = new AndroidJavaObject("com.trackier.sdk.TrackierSDKConfig", context, appToken, environment);
                trackierSDKConfig.Call("setSDKVersion", "1.6.60");
                trackierSDKConfig.Call("setSDKType", "unity_android_sdk");
                trackierSDK.CallStatic("initialize", trackierSDKConfig);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        public static void initialize(TrackierConfig config)
        {
            try
            {
                AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                AndroidJavaObject context = activity.Call<AndroidJavaObject>("getApplicationContext");
                AndroidJavaObject trackierSDKConfig = new AndroidJavaObject("com.trackier.sdk.TrackierSDKConfig", context, config.appToken, config.environment);
                trackierSDKConfig.Call("setAppSecret", config.secretId, config.secretKey);
                trackierSDKConfig.Call("setManualMode", config.manualMode);
                trackierSDKConfig.Call("disableOrganicTracking", config.disableOrgnaic);
                trackierSDKConfig.Call("setSDKVersion", "1.6.64");
                trackierSDKConfig.Call("setSDKType", "unity_android_sdk");
                if (config.attributionParams != null && config.attributionParams.Count > 0)
                {
                    AndroidJavaObject attributionParams = new AndroidJavaObject("com.trackier.sdk.AttributionParams");

                    if (config.attributionParams.ContainsKey("partnerId"))
                        attributionParams.Set("parterId", config.attributionParams["partnerId"]);

                    if (config.attributionParams.ContainsKey("siteId"))
                        attributionParams.Set("siteId", config.attributionParams["siteId"]);

                    if (config.attributionParams.ContainsKey("subSiteID"))
                        attributionParams.Set("subSiteID", config.attributionParams["subSiteID"]);

                    if (config.attributionParams.ContainsKey("channel"))
                        attributionParams.Set("channel", config.attributionParams["channel"]);

                    if (config.attributionParams.ContainsKey("ad"))
                        attributionParams.Set("ad", config.attributionParams["ad"]);

                    if (config.attributionParams.ContainsKey("adId"))
                        attributionParams.Set("adId", config.attributionParams["adId"]);

                    trackierSDKConfig.Call("setAttributionParams", attributionParams);
                }


                if (config.hasDeferredDeeplinkCallback == true)
                {
                    DeferredDeeplinkListener deeplink = new DeferredDeeplinkListener(config.deferredDeeplinkDelegate);
                    trackierSDKConfig.Call("setDeepLinkListener", deeplink);
                }
                trackierSDK.CallStatic("initialize", trackierSDKConfig);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        private class DeferredDeeplinkListener : AndroidJavaProxy
        {
            private Action<string> callback;

            public DeferredDeeplinkListener(Action<string> pCallback) : base("com.trackier.sdk.DeepLinkListener")
            {
                this.callback = pCallback;
            }

            public void onDeepLinking(AndroidJavaObject deeplink)
            {
                string deeplinkURL = deeplink.Call<string>("getUrl");
                callback(deeplinkURL);
            }
        }

        public static void setUserName(string userName)
        {
            try
            {
                AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                trackierSDK.CallStatic("setUserName", userName);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        public static void setUserPhone(string userPhone)
        {
            try
            {
                AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                trackierSDK.CallStatic("setUserPhone", userPhone);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        public static void setUserEmail(string userEmail)
        {
            try
            {
                AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                trackierSDK.CallStatic("setUserEmail", userEmail);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        public static void setUserId(string userId)
        {
            try
            {
                AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                trackierSDK.CallStatic("setUserId", userId);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        public static void setDOB(string dob)
        {
            try
            {
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                trackierSDK.CallStatic("setDOB", dob);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        public static void setGender(string gender)
        {
            try
            {
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                trackierSDK.CallStatic("setGender", gender);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        public static void parseDeepLink(string deeplink)
        {
            try
            {
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                trackierSDK.CallStatic("parseDeepLink", deeplink);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }

        public static void fireInstall()
        {
            try
            {
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                trackierSDK.CallStatic("fireInstall");
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }


        public static string getTrackierId() 
        {
            string trackierId = "";
            try
            {
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                trackierId = trackierSDK.CallStatic<string>("getTrackierId");
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
                return ""; 
            }
            return trackierId;
        }


        public static void TrackEvent(TrackierEvent te)
        {
            try
            {
                AndroidJavaObject trackierSDK = new AndroidJavaObject("com.trackier.sdk.TrackierSDK");
                AndroidJavaObject TrackEventClass = new AndroidJavaObject("com.trackier.sdk.TrackierEvent", te.EventId);
                TrackEventClass.Set("orderId", te.orderId);
                TrackEventClass.Set("currency", te.currency);
                TrackEventClass.Set("param1", te.param1);
                TrackEventClass.Set("param2", te.param2);
                TrackEventClass.Set("param3", te.param3);
                TrackEventClass.Set("param4", te.param4);
                TrackEventClass.Set("param5", te.param5);
                TrackEventClass.Set("param6", te.param6);
                TrackEventClass.Set("param7", te.param7);
                TrackEventClass.Set("param8", te.param8);
                TrackEventClass.Set("param9", te.param9);
                TrackEventClass.Set("param10", te.param10);
                TrackEventClass.Set("couponCode", te.couponCode);
                //TrackEventClass.Set("revenue", te.revenue);
                // TrackEventClass.Set("ev",AndroidUtils.CreateJavaMapFromDictainary(te.eventValues));
                trackierSDK.CallStatic("trackEvent", TrackEventClass);
            }
            catch (System.Exception e)
            {
                Debug.Log("System.Exception: " + e.Message);
            }
        }
    }
#endif
}
