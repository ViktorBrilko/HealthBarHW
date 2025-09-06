using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _damage;
    [SerializeField] private int _heal;

    private int _currentHealth;

    public int CurrentHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage()
    {
        if (_currentHealth - _damage < 0)
        {
            _currentHealth = 0;
        }
        else
        {
            _currentHealth -= _damage;
        }
    }

    public void Heal()
    {
        if (_currentHealth + _heal > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
        else
        {
            _currentHealth += _heal;
        }
    }
}