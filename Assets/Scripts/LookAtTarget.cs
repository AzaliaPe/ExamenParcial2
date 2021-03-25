using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LookAtTarget : MonoBehaviour {

	static public GameObject target; 

	void Start () 
	{
		if (target == null) 
		{
			target = this.gameObject;
		}
	}

	void Update () 
	{
		if (target)
			transform.LookAt(target.transform);
	}
}
