using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private PlayerPistol _playerPistol;
    [SerializeField] private StartScreen _startScreen;
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private EndScreen _endScreen;
    [SerializeField] private Score _score;

    private void OnEnable()
    {
        _startScreen.PlayButtonClicked += OnPlayButtonClick;
        _endScreen.RestartButtonClicked += OnRestartButtonClick;
        _playerPistol.GameOver += OnGameOver;
    }

    private void OnDisable()
    {
        _startScreen.PlayButtonClicked -= OnPlayButtonClick;
        _endScreen.RestartButtonClicked -= OnRestartButtonClick;
        _playerPistol.GameOver -= OnGameOver;
    }

    private void Start()
    {
        Time.timeScale = 0;
        _startScreen.Open();
    }

    private void OnGameOver()
    {
        Time.timeScale = 0;
        _endScreen.Open();
    }

    private void OnRestartButtonClick()
    {
        _enemySpawner.ClearContainer();
        _score.Reset();
        _endScreen.Close();
        StartGame();
    }
    private void OnPlayButtonClick()
    {
        _startScreen.Close();
        StartGame();
    }

    private void StartGame()
    {
        Time.timeScale = 1;
        _playerPistol.Reset();
    }
}