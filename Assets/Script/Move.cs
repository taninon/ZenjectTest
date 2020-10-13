using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Move : MonoBehaviour
{
	[Inject]
	private IInputProvider inputProvider;

	[SerializeField] Rigidbody _rigidbody;

	public float jumpPower;

	public void SetInputProvider(IInputProvider input)
	{
		inputProvider = input;
	}

	private void Jump() {
		_rigidbody.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
	}

	void Update()
	{
		if (inputProvider.IsJump())
		{
			Jump();
		}

		_rigidbody.AddForce(new Vector3(inputProvider.GetHorizontal(),0, inputProvider.GetVertical()));
	}


}
