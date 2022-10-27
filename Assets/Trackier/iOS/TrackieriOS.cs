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
#if UNITY_IOS
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
		private static extern void TrackierSDK_TrackEvent(string eventId);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_couponCode(string couponCode);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_orderId(string orderId);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_discount(float discount);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_currency(string currency);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_revenue(float revenue);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param1(string param1);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param2(string param2);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param3(string param3);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param4(string param4);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param5(string param5);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param6(string param6);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param7(string param7);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param8(string param8);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param9(string param9);

		[DllImport("__Internal")]
		private static extern void TrackierSDK_param10(string param10);

#endif
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

		public static void TrackEvent(TrackierEvent eventId)
		{
			TrackierSDK_couponCode(eventId.couponCode);
			TrackierSDK_orderId(eventId.orderId);
			TrackierSDK_discount(eventId.discount);
			TrackierSDK_currency(eventId.currency);
			TrackierSDK_revenue(eventId.revenue);
			TrackierSDK_param1(eventId.param1);
			TrackierSDK_param2(eventId.param2);
			TrackierSDK_param3(eventId.param3);
			TrackierSDK_param4(eventId.param4);
			TrackierSDK_param5(eventId.param5);
			TrackierSDK_param6(eventId.param6);
			TrackierSDK_param7(eventId.param7);
			TrackierSDK_param8(eventId.param8);
			TrackierSDK_param9(eventId.param9);
			TrackierSDK_param10(eventId.param10);
			TrackierSDK_TrackEvent(eventId.EventId);
		}

	}
#endif
}
