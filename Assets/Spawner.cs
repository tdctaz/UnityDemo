using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
	public int count;
	public GameObject template;

	int spawned = 0;
	float elapsed = 0;

	private List<GameObject> gos = new List<GameObject>();

	// Use this for initialization
	void Start()
	{

	}

	void Update()
	{
		elapsed += Time.deltaTime;
		if (elapsed > 0.5f && spawned < count)
		{
			for (int i = 0; i < 499 && spawned < count; i++)
			{
				gos.Add((GameObject)Instantiate(template, new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f)), Quaternion.identity));
				spawned++;
			}
			elapsed = 0;
		}

		if (spawned == 0)
			return;

		// do monkey stuff
		int monkey = Random.Range(0, 5);
		if (monkey == 0)
		{
			// randomly delete stuff
			monkey = Random.Range(0, gos.Count);
			var go = gos[monkey];
			gos.RemoveAt(monkey);
			for (int i = 0; i < gos.Count; i++)
			{
				if (gos[i].transform.parent == go.transform)
					gos[i].transform.SetParent(go.transform.parent);
			}
			Destroy(go);
			spawned--;
		}

		monkey = Random.Range(0, 5);
		if (monkey == 1)
		{
			List<GameObject> gosInRoot = new List<GameObject>();
			for (int i = 0; i < gos.Count; i++)
			{
				if (gos[i].transform.parent == null)
					gosInRoot.Add(gos[i]);
			}

			if (gosInRoot.Count > 1)
			{
				var ape = Random.Range(0, gos.Count);
				monkey = Random.Range(0, gosInRoot.Count);
				while (gosInRoot[monkey] == gos[ape])
					monkey = Random.Range(0, gosInRoot.Count);

				gosInRoot[monkey].transform.SetParent(gos[ape].transform);
			}
		}
	}
}
