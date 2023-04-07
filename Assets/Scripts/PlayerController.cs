using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Action AttackInput;
	public Action HealInput;

	// Update is called once per frame 
	void Update()
    {
        if (Input.GetKeyDown("space")) {
            InvokeAttack();
		}

		if (Input.GetKeyDown("z")) {
			InvokeHeal();
		}
	}

	private void InvokeAttack () {
		AttackInput?.Invoke();
	}

	private void InvokeHeal () {
		HealInput?.Invoke();
	}

}
