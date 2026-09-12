using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
   [SerializeField] public float _randomTime = 1f;
   [SerializeField] public float _wait = 0.1f;
   [SerializeField] public GameObject _coinPrefab;
    private Transform _spawnerTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _spawnerTransform = this.transform;
    }

    void Update()
    {
        _wait -= _randomTime * Time.deltaTime;
    if (_wait <= 0)
    {
      Instantiate(_coinPrefab,_spawnerTransform);
       _wait = _randomTime;
        _randomTime = Random.Range(0.25f,1.0f);
    }
    }
}
