using UnityEngine;
using System;
using System.Diagnostics;

namespace com.trackier.sdk
{
    public class TrackierConfig
    {
        internal Action<string> deferredDeeplinkDelegate;
        internal string appToken;
        internal string environment;

        public TrackierConfig(String appToken, String environment)
        {
            this.appToken = appToken;
            this.environment = environment;
        }

        public void setDeferredDeeplinkDelegate(Action<string> deferredDeeplinkDelegate)
        {
            this.deferredDeeplinkDelegate = deferredDeeplinkDelegate;
        }

        public Action<string> getDeferredDeeplinkDelegate()
        {
            UnityEngine.Debug.Log("getDeferredDeeplinkDelegate()");
        }
    }
}

