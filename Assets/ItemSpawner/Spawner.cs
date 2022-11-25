using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _interval = 2;
    private float _elapsed;

    [SerializeField] private GameObject _original = null;

    [SerializeField] private GameObject _spawnPlace = null;

    private void Update()
    {
        _elapsed += Time.deltaTime;
        if (_elapsed > _interval)
        {
            _elapsed = 0;
            var item = Instantiate(_original);
            var rigidbody = item.GetComponent<Rigidbody>();
            var x = Random.Range(-5,5);
            var y = Random.Range(3,10);
            var z = Random.Range(-5,5);
            rigidbody.AddForce(x, y, z, ForceMode.Impulse);
        }
    }
}
