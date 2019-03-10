using System.Collections;
using System.Collections.Generic;
using socket.io;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("My Start");
		var serverUrl = "http://localhost:3000";
		var socket = Socket.Connect(serverUrl);
		
		
		// receive "news" event
		socket.On("chatevent", (string data) => {
			Debug.Log(data);

			// Emit raw string data
			socket.Emit("chatevent", "{ my: data }");

			// Emit json-formatted string data
			socket.EmitJson("chatevent2", @"{ ""my"": ""data"" }");
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
