using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

	[SerializeField] private Image playerHPBarFill;
	[SerializeField] private Image enemyHpBarFill;

	public void UpdatePlayerHPBar (float hpPercentage) {
		playerHPBarFill.fillAmount = hpPercentage;
	}

	public void UpdateEnemyHPBar (float hpPercentage) {
		enemyHpBarFill.fillAmount = hpPercentage;
	}	

}
