using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag(Consts.WheatTypes.GOLD_WHEAT))
        {
            other.gameObject.GetComponent<GoldWheatCollectable>().Collect();
        }

        if (other.CompareTag(Consts.WheatTypes.HOLLY_WHEAT))
        {
            other.gameObject.GetComponent<HollyWheatCollectable>().Collect();
        }

        if (other.CompareTag(Consts.WheatTypes.ROTTEN_WHEAT))
        {
            other.gameObject.GetComponent<RottenWheatCollectable>().Collect();
        }
    }
}
