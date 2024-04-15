using UnityEngine;
using System;
using System.Diagnostics;

namespace com.trackier.sdk
{
	public class TrackierConfig
	{
		internal Action<string> deferredDeeplinkDelegate;
		internal bool hasDeferredDeeplinkCallback;
		internal string appToken;
		internal string environment;
		internal string secretId;
		internal string secretKey;
		internal bool manualMode;
		internal bool disableOrgnaic;

		public TrackierConfig(String appToken, String environment)
		{
			this.appToken = appToken;
			this.environment = environment;
		}

		public void setManualMode(Boolean manualMode)
		{
			this.manualMode = manualMode;
		}

		public void disableOrganicTracking(Boolean disableOrgnaic)
		{
			this.disableOrgnaic = disableOrgnaic;
		}

		public void setDeferredDeeplinkDelegate(Action<string> deferredDeeplinkDelegate)
		{
			this.hasDeferredDeeplinkCallback = true;
			this.deferredDeeplinkDelegate = deferredDeeplinkDelegate;
		}

		public Action<string> getDeferredDeeplinkDelegate()
		{
			UnityEngine.Debug.Log("getDeferredDeeplinkDelegate()");
			return this.deferredDeeplinkDelegate;
		}
	}
}

