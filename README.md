# unity-sdk
Getting started
To integrate the Trackier SDK into your Unity project, follow these steps.

Get the SDK
As of version 1.0.1 you can download the latest version from our [releases page](https://github.com/trackier/unity-sdk/releases).

Add the SDK to your project
Open your project in the Unity Editor, go to Assets → Import Package → Custom Package and select the downloaded Unity package file.
 
![unity](https://user-images.githubusercontent.com/34488320/108677807-34c22f80-7510-11eb-804b-c4795633fd23.jpg)
 
 
Integrate the SDK into your app

Initialize Trackier SDK :-
After importing package successfully, you would be seeing a Trackier named folder in which you will find Trackier.cs file.
 
In the following line add your app_token.

  	using com.trackier.sdk;
  
  
 	TrackierUnity.start("xxxx-xx-4505-bc8b-xx"); 
 
TrackEvent :-

       TrackierEvent trackierEvent = new TrackierEvent("eventId");
       trackierEvent.param1 = "param";
       TrackierUnity.trackierEvent(trackierEvent);
 
 
 Upon successfully initializing sdk and tracking events export the whole project as Android Studio Projects and open the project in android studio.
 
 
 In android studio,
 
 1.Add the following dependencies in app_level gradle , example here in my structure its Module: appName.launcer
 
        implementation 'com.trackier:android-sdk:1.0.5'
	
         dependencies{
	     implementation project(':unityLibrary')
	     implementation 'com.trackier:android-sdk:1.6.12'
	   }
 
 
2. 	Add the following permission in Manifest file

	    <uses-permission android:name="android.permission.INTERNET" />
	    <uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
	    <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 


