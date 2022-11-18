using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackierEvent
{
	public string EventId;
	public TrackierEvent(string EventId)
	{
		this.EventId = EventId;
	}
	public string orderId = "";
	public string currency = "";
	public string param1 = "";
	public string param2 = "";
	public string param3 = "";
	public string param4 = "";
	public string param5 = "";
	public string param6 = "";
	public string param7 = "";
	public string param8 = "";
	public string param9 = "";
	public string param10 = "";
	public string couponCode = "";
	public float discount = 0;
	public float revenue = 0;
	public IDictionary<string, object> eventValues = null;

	public static string LEVEL_ACHIEVED = "1CFfUn3xEY";
	public static string ADD_TO_CART = "Fy4uC1_FlN";
	public static string ADD_TO_WISHLIST = "AOisVC76YG";
	public static string COMPLETE_REGISTRATION = "mEqP4aD8dU";
	public static string TUTORIAL_COMPLETION = "99VEGvXjN7";
	public static string PURCHASE = "Q4YsqBKnzZ";
	public static string SUBSCRIBE = "B4N_In4cIP";
	public static string START_TRIAL = "jYHcuyxWUW";
	public static string ACHIEVEMENT_UNLOCKED = "xTPvxWuNqm";
	public static string CONTENT_VIEW = "Jwzois1ays";
	public static string TRAVEL_BOOKING = "yP1-ipVtHV";
	public static string SHARE = "dxZXGG1qqL";
	public static string INVITE = "7lnE3OclNT";
	public static string LOGIN = "o91gt1Q0PK";
	public static string UPDATE = "sEQWVHGThl";
}