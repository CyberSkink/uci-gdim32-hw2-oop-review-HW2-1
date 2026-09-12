using System;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;

    private float _jumpHeight = 5;

    [SerializeField] public GameObject _ice;
    [SerializeField] public GameObject _coin;
    
    [SerializeField] public TMP_Text _UI;

    [SerializeField] private int _coinValue = 1;

    private int _coinCount = 0;

    
    private Collider2D _iceCollider;
    public bool _touchingGround;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _iceCollider = _ice.GetComponent<BoxCollider2D>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _coinCount += _coinValue;
        _UI.SetText("Coins: " + _coinCount.ToString());
        Destroy(collision.gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider == _iceCollider)
        {
            _touchingGround = true;
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider == _iceCollider)
        {
             _touchingGround = false;
        }
           

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && _touchingGround)
        {
          _rb.linearVelocity = new Vector2(_rb.linearVelocity.x,_jumpHeight);
        }

    }
}
