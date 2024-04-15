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
		TrackierAndroid.setUserId(userId);
#endif
#if UNITY_IOS
		TrackieriOS.setUserID(userId);
#endif
	}

	public static void setDOB(string dob)
	{
		if (IsEditor())
		{
			return;
		}

#if UNITY_ANDROID
            TrackierAndroid.setDOB(dob);
#endif
#if UNITY_IOS
		    TrackieriOS.setDOB(dob);
#endif
		}

	public static void setGender(string gender)
	{
		if (IsEditor())
		{
			return;
		}

#if UNITY_ANDROID
            TrackierAndroid.setGender(gender);
#endif
#if UNITY_IOS
		    TrackieriOS.setGender(gender);
#endif
		}


		public static void parseDeepLink(string deeplink)
		{
			if (IsEditor())
			{
				return;
			}

#if UNITY_ANDROID
            TrackierAndroid.parseDeepLink(deeplink);
#endif
		}

		public static void fireInstall()
		{
			if (IsEditor())
			{
				return;
			}

#if UNITY_ANDROID
            TrackierAndroid.fireInstall();
#endif
		}

#if UNITY_ANDROID
	public static string getAd()
	{
		if (IsEditor())
		{
			return "";
		}

		return TrackierAndroid.getAd();
	}

	public static string getAdID()
	{
		if (IsEditor())
		{
			return "";
		}

		return TrackierAndroid.getAdID();
	}

	public static string getAdSet()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getAdSet();
	}

	public static string getAdSetID()
	{
		if (IsEditor())
		{
			return "";
		}

		return TrackierAndroid.getAdSetID();
	}

	public static string getCampaign()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getCampaign();
	}

	public static string getCampaignID()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getCampaignID();
	}

	public static string getChannel()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getChannel();
	}

	public static string getDlv()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getDlv();
	}

	public static string getPid()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getPid();
	}

	public static string getP1()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getP1();
	}

	public static string getP2()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getP2();
	}

	public static string getP3()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getP3();
	}

	public static string getP4()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getP4();
	}

	public static string getP5()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getP5();
	}

	public static string getClickId()
	{
		if (IsEditor())
		{
				return "";
		}
		return TrackierAndroid.getClickId();
	}

	public static string getIsRetargeting()
	{
		if (IsEditor())
		{
			return "";
		}
		return TrackierAndroid.getIsRetargeting();
	}
#endif

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

