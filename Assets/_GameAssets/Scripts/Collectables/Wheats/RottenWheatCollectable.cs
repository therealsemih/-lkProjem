using UnityEngine;

public class RottenWheatCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] private WheatDesignSO _wheatDesignSO;
    [SerializeField] private PlayerController _playerController;
    public void Collect()
    {
        _playerController._setMovementSpeed(_wheatDesignSO.IncreaseDecreaseMultiplier, _wheatDesignSO.ResetBoostDuration);
        Destroy(gameObject);
    }
}
