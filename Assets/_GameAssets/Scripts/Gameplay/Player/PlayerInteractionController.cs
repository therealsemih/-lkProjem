using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    private PlayerController _playerController;
    void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other) 
    {

        if(other.gameObject.TryGetComponent<ICollectable>(out var collectible))
        {
            collectible.Collect();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent<IBoostable>(out var boostable))
        {
          boostable.Boost(_playerController);  
        }
    }
}
