using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private UIManager uiManager;

	[SerializeField] private PlayerController playerController;
	[SerializeField] private Player player;
	[SerializeField] private Enemy enemy;

	private void Start () {
		playerController.AttackInput += OnAttackInput;
		playerController.HealInput += OnPlayerHeal;
		
		player.HPChange += OnUIPlayerHPChange;

		enemy.HPChange += OnUIEnemyHPChange; 
	}

	private void OnUIPlayerHPChange (float percentageHp) {
		uiManager.UpdatePlayerHPBar(percentageHp);
	}

	private void OnUIEnemyHPChange (float percentageHp) {
		uiManager.UpdateEnemyHPBar(percentageHp);
	}

	private void OnPlayerHeal () {
		player.Heal();
	}

	private void OnAttackInput () {
		PlayerAttack();
	}

	private void EnemyAttack () {
		player.GetDamaged(enemy.GetAttackDamageValue());
	}

	private void PlayerAttack () {
		enemy.GetDamaged(player.GetAttackDamageValue());
	}

}
