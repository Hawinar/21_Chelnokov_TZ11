using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _livesTMP;
    [SerializeField] private TextMeshProUGUI _coinsTMP;
    [SerializeField] private Button _pauseBTN;

    [SerializeField] private GameObject _rate;

    [SerializeField] private TextMeshProUGUI _bestScoreTMP;
    [SerializeField] private TextMeshProUGUI _lastScoreTMP;
    [SerializeField] private TextMeshProUGUI _attempsTMP;

    [SerializeField] private Button _playBTN1;
    [SerializeField] private Button _goMainMenu;
    void Start()
    {
        Time.timeScale = 1f;
        GameManager.Coins = 0;

        _pauseBTN.onClick.AddListener(() => Pause());

        _playBTN1.onClick.AddListener(() => StartGame());
        _goMainMenu.onClick.AddListener(() => GoMenu());

        _rate.SetActive(false);
    }

    void Update()
    {
        _livesTMP.text = $"x{GameManager.Lives}";
        _coinsTMP.text = $"{GameManager.Coins}";

        if (GameManager.Lives == 0)
        {
            GameManager.LastScore = GameManager.Coins;
            if(GameManager.Coins > GameManager.BestScore)
            {
                GameManager.BestScore = GameManager.Coins;
            }
            _bestScoreTMP.text = "Лучший результат: " + GameManager.BestScore;
            _lastScoreTMP.text = "Последний результат: " + GameManager.LastScore;
            _attempsTMP.text = "Всего попыток: " + GameManager.Attempts;
            _rate.SetActive(true);
        }
    }
    private void Pause()
    {
        if(Time.timeScale == 0f)
            Time.timeScale = 1f;
        else
            Time.timeScale = 0f;
    }
    private void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    private void GoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
