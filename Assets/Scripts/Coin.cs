using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-_speed * Time.deltaTime,0));
    }
}
