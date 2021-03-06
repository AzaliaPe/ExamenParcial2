using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAtTarget : MonoBehaviour 
{

	public GameObject target; 

	void Start() 
	{
		if (target == null) 
		{
			target = this.gameObject;
		}
	}

	void OnMouseDown () 
	{
		LookAtTarget.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(100 * target.transform.localScale.x, 1, 5);
	}
}
