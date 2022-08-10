using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollSpawn : MonoBehaviour
{

    [SerializeField] private GameObject _teleportBoll;
    [SerializeField] private Transform _aimTransform;
    [SerializeField] private float _speed = 1f;

    void Update()
    {
        if (FindObjectOfType<TeleportBoll>() == null)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector2 direction = _aimTransform.position - transform.position;
                GameObject boll = Instantiate(_teleportBoll, transform.position, Quaternion.identity);
                Rigidbody2D bollRigidbody = boll.GetComponent<Rigidbody2D>();


                bollRigidbody.AddForce(direction.normalized * _speed, ForceMode2D.Impulse);

            }
        }
    }
}
