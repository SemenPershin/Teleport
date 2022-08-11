using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _lerpTime = 1f;
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, _playerTransform.position,Time.deltaTime* _lerpTime);

    }
}
