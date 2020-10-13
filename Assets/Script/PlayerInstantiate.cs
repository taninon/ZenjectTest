using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerInstantiate : MonoBehaviour
{
	[Inject] private DiContainer container;

	[SerializeField]
	GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
		container.InstantiatePrefab(prefab);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
