using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int _score = 10;
    public int Score => _score;
    private void Update()
    {
        transform.Rotate(0, 0.2F, 0, Space.World);
    }
}
