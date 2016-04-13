using UnityEngine;

public class CameraController : MonoBehaviour
{
	public float RotationSpeed = 90.0f;
	public float MovementSpeed = 5.0f;

	void Update ()
	{
		var rotation = Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime;
		var movement = Input.GetAxis("Vertical") * MovementSpeed * Time.deltaTime;

		transform.Rotate(0.0f, rotation, 0.0f);
		var forward = transform.rotation * Vector3.forward;
		transform.Translate(forward * movement);
	}
}
