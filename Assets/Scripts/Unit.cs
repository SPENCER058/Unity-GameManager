using System;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float hp;
    [SerializeField] private float attackDamage;
	[SerializeField] private float healPoint;

	public Action HPChange;

	public void Heal () {
		hp += healPoint;
	}

	public void GetDamaged (float damageValue) {
        hp -= damageValue;
		HPChange?.Invoke ();
    }

	// Get Stat
	public float GetHPValue () {
		return hp;
	}

	public float GetAttackDamageValue () {
		return attackDamage;
	}
}
