using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor.PackageManager;
using UnityEngine;


namespace com.trackier.sdk
{
#if UNITY_IOS
	public class TrackieriOS
	{
		[DllImport("__Internal")]
		private static extern void TrackierSDK_initialize(string appToken, string env);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_setUserId(string userID);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_setUserEmail(string userEmail);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_setUserPhone(string userPhone);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_setUserName(string userName);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_TrackEvent(string eventId, string jsonInfo);

		public static void initialize(TrackierConfig config)
		{
			TrackierSDK_initialize(config.appToken,config.environment);
		}

		public static void setUserID(string userId)
		{
			TrackierSDK_setUserID(userId);
		}

		public static void setUserEmail(string userName)
		{
			TrackierSDK_setUserEmail(userName);
		}

		public static void setUserPhone(string userPhone)
		{
			TrackierSDK_setUserPhone(userPhone);
		}

		public static void setUserName(string userName)
		{
			TrackierSDK_setUserName(userName);
		}

		public static void TrackEvent(TrackierEvent ev)
		{
			Dictionary<string, string> eventParams = new Dictionary<string, string>();
			eventParams.Add("orderId", ev.orderId);
			eventParams.Add("discount", Convert.ToString(ev.discount));
			eventParams.Add("revenue", Convert.ToString(ev.revenue));
			eventParams.Add("couponCode", ev.couponCode);
			eventParams.Add("currency", ev.currency);
			eventParams.Add("param1", ev.param1);
			eventParams.Add("param2", ev.param2);
			eventParams.Add("param3", ev.param3);
			eventParams.Add("param4", ev.param4);
			eventParams.Add("param5", ev.param5);
			eventParams.Add("param6", ev.param6);
			eventParams.Add("param7", ev.param7);
			eventParams.Add("param8", ev.param8);
			eventParams.Add("param9", ev.param9);
			eventParams.Add("param10", ev.param10);
			string jsonString = JsonConvert.SerializeObject(eventParams, Formatting.Indented);
			TrackierSDK_TrackEvent(ev.EventId, jsonString);
		}

	}
#endif
}

