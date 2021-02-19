# unity-sdk
Getting started
To integrate the Trackier SDK into your Unity project, follow these steps.

Get the SDK
As of version 1.0.1 you can add Trackier SDK from Unity Asset Store to your app. Alternatively, you can download the latest version from our releases page.

Add the SDK to your project
Open your project in the Unity Editor, go to Assets → Import Package → Custom Package and select the downloaded Unity package file.
 
<IMAGE>
 
 
Integrate the SDK into your app

Initialize Trackier SDK :-
After importing package successfully, you would be seeing a Trackier named folder in which you will find Trackier.cs file.
 
In the following line add your app_token.
 
  TrackierUnity.start(this.appToken); 
 
TrackEvent :-
  <CODE LEFT>
 
 
 Upon successfully initializing sdk and tracking events export the whole project as Android Studio Projects and open the project in android studio.
 
 
 In android studio,
 
 1.Add the following dependencies in app_level gradle , example here in my structure its Module: appName.launcer
 
        implementation 'com.trackier:android-sdk:1.0.1'
	
        dependencies{
	 implementation project(':unityLibrary')
	 implementation 'com.trackier:android-sdk:1.0.1'
	 }
 
 
 
2. 	Add the following permission in Manifest file

	    <uses-permission android:name="android.permission.INTERNET" />
	    <uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
	    <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
 

 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 


