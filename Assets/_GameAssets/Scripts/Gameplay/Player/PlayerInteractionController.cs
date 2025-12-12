using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag(Consts.WheatTypes.GOLD_WHEAT))
        {
            Debug.Log("Gold Wheat Collected");
        }

        if (other.CompareTag(Consts.WheatTypes.HOLLYD_WHEAT))
        {
            Debug.Log("Holly Wheat Collected");
        }

        if (other.CompareTag(Consts.WheatTypes.ROTTEN_WHEAT))
        {
            Debug.Log("Rotten Wheat Collected");
        }
    }
}
