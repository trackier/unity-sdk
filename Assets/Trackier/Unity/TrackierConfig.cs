using System;
using System.Collections.Generic;

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
		internal Dictionary<string, string> attributionParams = new Dictionary<string, string>();


		public TrackierConfig(String appToken, String environment)
		{
			this.appToken = appToken;
			this.environment = environment;
		}

		public void setAppSecret(String secretId, String secretKey)
		{
			this.secretId = secretId;
			this.secretKey = secretKey;
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

		public void setAttributionParams(Dictionary<string, string> paramsDict)
		{
			if (paramsDict == null) return;

			foreach (var kvp in paramsDict)
			{
				this.attributionParams[kvp.Key] = kvp.Value; 
			}
		}

		public void setAttributionParam(string key, string value)
		{
			attributionParams[key] = value;
		}

	}
}

