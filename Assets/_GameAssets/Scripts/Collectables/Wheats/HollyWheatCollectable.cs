using UnityEngine;

public class HollyWheatCollectable : MonoBehaviour, ICollectable
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private float _forceIncrease;
    [SerializeField] private float _resetBoostDuration;
    public void Collect()
    {
        _playerController.SetJumpForce(_forceIncrease, _resetBoostDuration);
        Destroy(gameObject);
    }

}
