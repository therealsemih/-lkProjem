using System;
using UnityEditor.Build.Content;
using UnityEngine;

public class GameManager: MonoBehaviour
{  
    public static GameManager Instance {get; private set; }

    public event Action<GameStates> OnGameStateChanged;

    [Header("References")]
    [SerializeField] private EggCounterUI _eggCounterUI;
    [SerializeField] private WinLoseUI _winLoseUI;
    
    [Header("Settimgs")]

    [SerializeField] private int _maxEggCount =5;

    private GameStates _currentGameState;
    private int _currentEggCount;
    private void Awake()
    {
        Instance = this;
    }
    private void OnEnable()
    {
        ChangeGameState(GameStates.Play);
    }

    public void ChangeGameState(GameStates gameState)
    {
        OnGameStateChanged?.Invoke(gameState);
        _currentGameState = gameState;
        Debug.Log("Game State: "+gameState);
    }
    public void OnEggCollected()
    {
        _currentEggCount++;
        _eggCounterUI.SetEggCounterText(_currentEggCount, _maxEggCount);
        

        if(_currentEggCount >= _maxEggCount)
        {
            //WIN
            _eggCounterUI.SetEggCompleted();
            ChangeGameState(GameStates.GameOver);
            _winLoseUI.OnGameWin();
        }        
    }
    public GameStates GetCurrentGameStates()
    {
        return _currentGameState;
        
    }
}
