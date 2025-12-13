using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {

        if(other.gameObject.TryGetComponent<ICollectable>(out var collectible))
        {
            collectible.Collect();
        }
    }
}
