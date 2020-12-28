using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
	[SerializeField] private Transform focusEntity;
	[SerializeField] private float heightOffset = 1f;
	[SerializeField] private float perimeterDistanceMin = 1f;
	[SerializeField] private float perimeterDistanceMax = 5f;

	void Update()
	{
		Vector3 newPos;
		
		Vector3 camPosFlat = transform.position.Flattened();
		Vector3 entityPosFlat = focusEntity.position.Flattened();
		Vector3 camToEntityFlatNormal = (camPosFlat - entityPosFlat).normalized;
		
		float distanceFromEntity = Mathf.Clamp(
			Vector3.Distance(camPosFlat, entityPosFlat),
			perimeterDistanceMin,
			perimeterDistanceMax);

		newPos = entityPosFlat + (camToEntityFlatNormal * distanceFromEntity);
		newPos.y = focusEntity.position.y + heightOffset;

		transform.position = newPos;
		transform.LookAt(focusEntity, Vector3.up);
	}
}