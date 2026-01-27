using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePopup : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TimerUI _timerUI;
    [SerializeField] Button _tryAgainbutton;
    [SerializeField] Button _mainMenuButton;
    [SerializeField] TMP_Text _timerText;


    private void Awake()
    {
        _tryAgainbutton.onClick.AddListener(OnTryAgainButtonClicked);
    }
    private void OnEnable()
    {
        _timerText.text = _timerUI.GetFinalTime();
    }
    private void OnTryAgainButtonClicked()
    {
        SceneManager.LoadScene(Consts.SceneNames.GAME_SCENE);
        DOTween.KillAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
