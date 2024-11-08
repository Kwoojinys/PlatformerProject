using UnityEngine;
using System.Collections;

public class FollowPlayer2 : MonoBehaviour
{
	public Vector3 offset;			// The offset at which the Health Bar follows the player.
	
	private Transform player2;		// Reference to the player.
	
	
	void Awake ()
	{
		// Setting up the reference.
		player2 = GameObject.FindGameObjectWithTag("Player2").transform;
	}
	
	void Update ()
	{
		// Set the position to the player's position with the offset.
		transform.position = player2.position + offset;
	}
}
