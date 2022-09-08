using System;
using System.Collections.Generic;
using UnityEngine;

namespace com.trackier.sdk
{
	public class TrackierUnity : MonoBehaviour
	{
		public string AppToken = "";

		void Awake()
		{
			if (IsEditor())
			{
				return;
			}

		    TrackierUnity.start(this.AppToken);
		}

		public static void start(string appToken)
		{
			if (IsEditor())
			{
				return;
			}

           #if UNITY_ANDROID

		       TrackierAndroid.Start(appToken, "");

           #endif
		}

		public static void TrackEvent(TrackierEvent te)
		{
			if (IsEditor())
			{
				return;
			}

            #if UNITY_ANDROID

		       TrackierAndroid.TrackEvent(te);

            #endif
		}
		  
		private static bool IsEditor()
		{
           #if UNITY_EDITOR

		      return true;

           #else

		      return false;
			  
           #endif
		}
	}
}

