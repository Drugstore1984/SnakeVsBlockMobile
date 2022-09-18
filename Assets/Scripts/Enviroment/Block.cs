using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private ParticleSystem _particleSystem;
    [Header("Gradient color")]
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color1;
    [SerializeField] private Color _color2;
    public int damage => _damage;
    [SerializeField] private TextMeshPro _blockText;
    private void OnValidate()
    {
        SetTextBlock();
    }
    private void Start()
    {
        SetColor();
    }
    private void OnTriggerEnter(Collider other)
    {
        SetParticleColor();
        DestroyBlock();
    }
    private void SetTextBlock()
    {
        _blockText.text = _damage.ToString();
    }
    private void SetColor()
    {
        _meshRenderer.material.color = Color.Lerp(_color1, _color2, _damage * 0.1f);
    }
    private void SetParticleColor()
    {
        ParticleSystem.MainModule psMain = _particleSystem.GetComponent<ParticleSystem>().main;
        Color newColor = _meshRenderer.material.color;
        psMain.startColor = new Color(newColor.r, newColor.g, newColor.b, 1);
        _particleSystem.Play();
    }
    private void DestroyBlock()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        GetComponentInChildren<TextMeshPro>().gameObject.SetActive(false);
        Destroy(gameObject, 2f);
    }
}
