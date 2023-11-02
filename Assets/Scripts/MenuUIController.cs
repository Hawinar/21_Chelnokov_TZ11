using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIController : MonoBehaviour
{
    [SerializeField] private Button _playBTN1;
    [SerializeField] private Button _playBTN2;

    [SerializeField] private TextMeshProUGUI _bestScoreTMP;
    [SerializeField] private TextMeshProUGUI _lastScoreTMP;
    [SerializeField] private TextMeshProUGUI _attempsTMP;
    private void Start()
    {
        _playBTN1.onClick.AddListener(() => StartCoroutine(StartGame()));
        _playBTN2.onClick.AddListener(() => StartCoroutine(StartGame()));
    }

    // Update is called once per frame
    private void Update()
    {
        _bestScoreTMP.text = "Лучший результат: " + GameManager.BestScore;
        _lastScoreTMP.text = "Последний результат: " + GameManager.LastScore;
        _attempsTMP.text = "Всего попыток: " + GameManager.Attempts;
    }
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Game");
    }
}
