 using UnityEngine;

public class EggColectible : MonoBehaviour, ICollectable
{
    private bool isCollected =false;
    public void Collect()
    {
         if (isCollected) return; 
        isCollected = true;
      GameManager.Instance.OnEggCollected();
       Destroy(gameObject);
    }
}
