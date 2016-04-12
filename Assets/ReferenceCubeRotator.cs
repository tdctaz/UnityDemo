using UnityEngine;

public class ReferenceCubeRotator : MonoBehaviour
{
	void Update()
	{
		transform.Rotate(Vector3.up * 30.0f * Time.deltaTime);
	}
}
