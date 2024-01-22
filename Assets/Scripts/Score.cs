using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _score;

    private float _currentTime;

    private void Start()
    {
        Reset();
    }

    private void Update()
    {
        CountScore();
    }

    public void Reset()
    {
        _currentTime = 0;
    }

    private void CountScore()
    {
        _currentTime += Time.deltaTime;
        _score.text = _currentTime.ToString("F0");
    }
}
