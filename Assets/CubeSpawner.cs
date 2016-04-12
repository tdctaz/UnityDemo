using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
	public GameObject Instance;
	public int Count;
	public Vector3 Bounds;

	public void Start()
	{
		for (int i = 0; i < Count; i++)
		{
			var pos = new Vector3(Random.Range(-Bounds.x, Bounds.x), Random.Range(-Bounds.y, Bounds.y), Random.Range(-Bounds.z, Bounds.z));
			var rotation = Quaternion.Euler(0, Random.Range(0.0001f, 360f), 0);
			Instantiate(Instance, pos, rotation);
		}
	}
}
