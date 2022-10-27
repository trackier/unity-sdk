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

		public static void initialize(TrackierConfig config)
		{
			if (IsEditor())
			{
				return;
			}

#if UNITY_ANDROID
			TrackierAndroid.initialize(config);
#endif

#if UNITY_IOS
			TrackieriOS.initialize(config);
#endif
		}

		public static void setUserName(string userName)
		{
			if (IsEditor())
			{
				return;
			}

#if UNITY_ANDROID
			TrackierAndroid.setUserName(userName);
#endif
#if UNITY_IOS
			TrackieriOS.setUserName(userName);
#endif
		}

		public static void setUserPhone(string userPhone)
		{
			if (IsEditor())
			{
				return;
			}

#if UNITY_ANDROID
			TrackierAndroid.setUserPhone(userPhone);
#endif
#if UNITY_IOS
			TrackieriOS.setUserPhone(userPhone);
#endif
		}

		public static void setUserEmail(string userEmail)
		{
			if (IsEditor())
			{
				return;
			}

#if UNITY_ANDROID
			TrackierAndroid.setUserEmail(userEmail);
#endif
#if UNITY_IOS
			TrackieriOS.setUserEmail(userEmail);
#endif
		}

		public static void setUserId(string userId)
		{
			if (IsEditor())
			{
				return;
			}

#if UNITY_ANDROID
			TrackierAndroid.setUserID(userEmail);
#endif
#if UNITY_IOS
			TrackieriOS.setUserID(userId);
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
#if UNITY_IOS
			TrackieriOS.TrackEvent(te);
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

