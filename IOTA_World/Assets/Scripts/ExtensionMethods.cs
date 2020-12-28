using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods
{
	public static Vector3 Flattened(this Vector3 vec3)
	{
		return new Vector3(vec3.x, 0,vec3.z);	
	}
}
