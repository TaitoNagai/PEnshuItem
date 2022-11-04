using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private int _totalScore = 0;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        _rigidbody.AddForce(h, 0, v);
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
