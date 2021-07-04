using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Time")]
    [SerializeField] private int _timeLeft = 30;
    [SerializeField] private int _redTime;
    private float _gameTime;
    [Space(height: 5f)]

    [Header("Text")]
    [SerializeField] private Text _timerText;
    [Space(height: 5f)]

    [Header("Camera")]
    [SerializeField] private Camera _camera;
    [Space(height: 5f)]

    [Header("Game Object")]
    [SerializeField] private SpriteRenderer _lightBulb;
    [Space(height: 5f)]

    [Header("End Game")]
    [SerializeField] private GameObject _menu;



    private void Start()
    {
        Time.timeScale = 1;
    }


    private void Update()
    {
        GameTimer();
    }


    private void GameTimer()
    {
        _timerText.text = _timeLeft.ToString() + " s.";
        _gameTime += 1 * Time.deltaTime;

        if (_gameTime >= 1)
        {
            _timeLeft--;
            _gameTime = 0;
        }

        else if (_timeLeft <= _redTime)
        {
            _timerText.color = Color.red;
        }

        if (_timeLeft <= 0)
        {
            _lightBulb.enabled = true;
            _camera.backgroundColor = Color.red;

            _menu.SetActive(true);

            Time.timeScale = 0;
        }
    }
}