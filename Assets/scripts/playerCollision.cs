using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

	public playerMovement m;
	void OnCollisionEnter(Collision c)
	{
        if (c.collider.tag == "obstacle")
		{
			m.enabled = false;
            FindObjectOfType<GameManager>().endGame();
		}
	}
}
