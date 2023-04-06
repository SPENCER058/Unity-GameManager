using UnityEngine;

public class GameManager : MonoBehaviour
{
	public delegate void GameOverEventHandler ();
	public static event GameOverEventHandler OnGameOver;

	private void Start () {
		OnEnable();
	}

	private void Update () {
		if (Input.GetKeyDown("a")) {
			GameOver();
		}
	}

	public void GameOver () {
		OnGameOver?.Invoke();
	}

	private void OnEnable () {
		GameManager.OnGameOver += HandleGameOver;
	}

	private void OnDisable () {
		GameManager.OnGameOver -= HandleGameOver;
	}

	private void HandleGameOver () {
		Debug.Log("Game Over");
	}
}
