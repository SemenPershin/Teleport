using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
   // [SerializeField] private float _lerpTime = 1f;
    void Update()
    {
        transform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y, transform.position.z);
       
    }
}
