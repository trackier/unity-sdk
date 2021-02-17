using System;
using System.Collections.Generic;
using UnityEngine;

namespace com.trackier.sdk
{
    public class TrackierUnity : MonoBehaviour
    {
        void Awake()
        {
            if (IsEditor())
            {
                return;
            }

            TrackierUnity.start("c814db62-c196-4505-bc8b-46fa8e37f688");
        }

        public static void start(String appToken)
        {
            if (IsEditor())
            {
                return;
            }

#if UNITY_ANDROID
			TrackierAndroid.Start(appToken, "");
#endif
        }

        public static void EventTrack(String EventID, TrackEvent trackEvent)
        {
            if (IsEditor())
            {
                return;
            }

#if UNITY_ANDROID
			TrackierAndroid.EventTrack(EventID,trackEvent);
#endif
        }

        private static bool IsEditor()
        {
#if UNITY_EDITOR
			//Debug.Log("errorMsgEditor");
			return true;
#else
            return false;
#endif
        }
    }
}

