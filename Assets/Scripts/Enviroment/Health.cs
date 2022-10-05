using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;
    public int health => _health;
    [SerializeField] private TextMeshPro _healthText;

    private void OnValidate()
    {
        SetTextHealth();
    }
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
    private void SetTextHealth()
    {
        _healthText.text = _health.ToString();
    }
}
