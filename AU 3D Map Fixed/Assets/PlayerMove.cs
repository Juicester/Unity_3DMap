using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{
	public Camera cam;
	void Update()
	{

		if (!isLocalPlayer) {
			cam.enabled = false;
			return;
		}

		var x = Input.GetAxis("Horizontal")*0.4f;
		var z = Input.GetAxis("Vertical")*0.4f;

		transform.Translate(x, 0, z);
	}

	public override void OnStartLocalPlayer()
	{	
		Vector3 playerPosition = this.transform.position;
		playerPosition.y = 0.0f;
		this.transform.position = playerPosition;

		//GetComponent<MeshRenderer>().material.color = Color.red;


			
	}
		
}