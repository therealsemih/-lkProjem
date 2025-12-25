using Unity.VisualScripting;
using UnityEngine;

public class healthManager : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 3;
    private int _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void Damage(int damage)
    {
        if(_currentHealth > 0)
        {
            _currentHealth -= damage;
            //TO DO; UI ANIMATION DAMAGE

            if (_currentHealth <= 0)
            {
                //TO DO; PLAYER DEAD
            }
        }
    }
    public void Heal(int healAmount)
    {
        if(_currentHealth > _maxHealth)
        {
            _currentHealth = Mathf.Min(_currentHealth + healAmount, _maxHealth);
        }
    }
}
