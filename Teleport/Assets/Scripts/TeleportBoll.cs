using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBoll : MonoBehaviour
{
    

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.R))
        {
            Destroy(gameObject);
        }

       if (Input.GetMouseButtonDown(0))
        {
            Transform _playerTransform = FindObjectOfType<Player>().GetComponent<Transform>();
            Rigidbody2D _playerRigidbody = FindObjectOfType<Player>().GetComponent<Rigidbody2D>();
            _playerTransform.position = transform.position;
            _playerRigidbody.velocity = Vector2.zero;
            Destroy(gameObject);
        }
    }
}
