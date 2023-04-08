using System;
using UnityEngine;

public class Unit : MonoBehaviour
{
	[SerializeField] private float minHp;
	[SerializeField] private float hp;
	[SerializeField] private float maxHp;
	[SerializeField] private float attackDamage;
	[SerializeField] private float healPoint;

	public Action<float> HPChange;
		
	private void Start () {
		maxHp = hp;
	}

	public void Heal () {
		if (hp < maxHp) {
			hp += healPoint;
			HPValueChange();
		}
	}

	public void GetDamaged (float damageValue) {
        hp -= damageValue;
		HPValueChange();
		if (hp < minHp) {
			// Unit Died
		}

    }

	// Get Stat
	public float GetHPValue () {
		return hp;
	}

	public float GetAttackDamageValue () {
		return attackDamage;
	}

	private void HPValueChange () {
		HPChange?.Invoke(hp / maxHp);
	}
}
