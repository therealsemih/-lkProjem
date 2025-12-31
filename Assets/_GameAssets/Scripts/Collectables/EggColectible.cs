 using UnityEngine;

public class EggColectible : MonoBehaviour, ICollectable
{
    public void Collect()
    {
       Debug.Log("Egg Collected");
       Destroy(gameObject);
    }
}
