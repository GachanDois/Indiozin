using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
	public Transform target;

	public float smoothSpeed = 0.125f;


	void lateUpdate()
	{
		transform.position = target.position;

		transform.LookAt(target);
	}
}
