using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody;

    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _hightofJump = 1f;
    [SerializeField] private float _angleofJump = 45f;
    [SerializeField] private float _stepRate = 1f;
                     private float _timer = 0f;
    [SerializeField] private float _steptimer = 1f;


    [SerializeField] private bool _isGrounded;
    



    void Update()
    {
        
        PlayerJump();
        TeleportStep();
    
    }
    void FixedUpdate()
    {
        PlayerMove();
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if(Vector2.Angle(Vector2.up, collision.contacts[0].normal) < _angleofJump)
        {
            _isGrounded = true;
        }
        
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {

        _isGrounded = false;
    }

    void PlayerMove()
    {

        _playerRigidbody.velocity = new Vector2 (0, _playerRigidbody.velocity.y);
      
        if (Input.GetKey(KeyCode.D))
        {
            _playerRigidbody.velocity = new Vector2(_speed, _playerRigidbody.velocity.y) ;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            _playerRigidbody.velocity = new Vector2(-_speed, _playerRigidbody.velocity.y);
        }
       
    }
    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _playerRigidbody.AddForce(Vector2.up * _hightofJump, ForceMode2D.Impulse);
        }
    }


    void TeleportStep()
    {
        
        _timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift) && _steptimer < _timer)
        {
            
            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector2(transform.position.x + _stepRate, transform.position.y);
                _timer = 0f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector2(transform.position.x - _stepRate, transform.position.y);
                _timer = 0f;
            }
        }
        

    }
    
}
