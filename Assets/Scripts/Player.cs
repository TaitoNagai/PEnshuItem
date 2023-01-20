using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Text _pointText;
    private Rigidbody _rigidbody;
    private int _totalScore = 0;
    [SerializeField] float _speed = 1f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var h = Input.GetAxis("Horizontal");
        _rigidbody.velocity= new Vector3(h, 0, 0)*_speed;

        _pointText.text = $"{"Point"}:{_totalScore}";
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.TryGetComponent<Item>(out var item))
        {
            _totalScore += item.Score;
            Debug.Log($"Item={item.Score}, TotalScore={_totalScore}");
            Destroy(other.gameObject);
        }
    }
}
