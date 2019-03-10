using socket.io;
using UnityEngine;
using UnityEngine.UI;

public class SocketMessage : MonoBehaviour
{
	public string serverUrl = "http://192.168.0.102:3000";
	public string chatEvent = "message";

	public Text message;
	
	private Socket socket;

	// Use this for initialization
	void Start()
	{
		socket = Socket.Connect(serverUrl);

		socket.On(chatEvent, (string data) =>
		{
			Debug.Log(data);
			message.text = data;
		});
	}
}
