using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private float _interval = 2;
    private float _elapsed;

    [SerializeField] private GameObject _item = null;
    [SerializeField] private GameObject _spawnPoint = null;

    private void Update()
    {
        _elapsed += Time.deltaTime;
        if(_elapsed > _interval)
        {
            _elapsed = 0;
            var item = Instantiate(_item);
            var rigidbody = item.GetComponent<Rigidbody>();
            var x = Random.Range(-5, 5);
            var y = Random.Range(10, 10);
            var z = Random.Range(0,0);
            rigidbody.AddForce(x, y, z, ForceMode.Impulse);
        }
    }
}
