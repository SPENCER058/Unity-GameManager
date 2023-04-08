using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

	[SerializeField] private Image playerHPBarFill;
	[SerializeField] private Image enemyHpBarFill;

	public void UpdatePlayerHPBar () {
		Debug.Log("Player UI Update Success");
	}

	public void UpdateEnemyHPBar () {
		Debug.Log("Enemy UI Update Success");
	}	

}
