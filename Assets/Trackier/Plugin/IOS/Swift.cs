using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Swift {
	#if UNITY_IOS && !UNITY_EDITOR
	[DllImport("__Internal")]
	private static extern void Start(string message);
	#endif

	// Use this method to call Example.swiftMethod() in Example.swift
	// from other C# classes.
	public static void CallSwiftMethod(string message) {
		#if UNITY_IOS && !UNITY_EDITOR
		Start(message);
		#endif

		#if UNITY_EDITOR
		Debug.Log(message);
		#endif
	}
}