using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private PlayerController playerController;
	[SerializeField] private Player player;
	[SerializeField] private Enemy enemy;

	private void Start () {
		playerController.AttackInput += OnAttackInput;
		playerController.HealInput += OnPlayerHeal;
		enemy.HPChange += OnUIEnemyHPChange;
		player.HPChange += OnUIPlayerHPChange;
	}

	private void OnUIPlayerHPChange () {
		throw new NotImplementedException();
	}

	private void OnUIEnemyHPChange () {
		throw new NotImplementedException();
	}

	private void OnPlayerHeal () {
		player.Heal();
	}

	private void OnAttackInput () {
		// Debug.Log(player.GetAttackDamageValue());
		PlayerAttack();
		// Debug.Log(enemy.GetHPValue());
	}

	private void EnemyAttack () {
		player.GetDamaged(enemy.GetAttackDamageValue());
	}

	private void PlayerAttack () {
		enemy.GetDamaged(player.GetAttackDamageValue());
	}

}
