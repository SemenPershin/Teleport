using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _aim;
  
   
    void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane (Vector3.forward, Vector3.zero);
        plane.Raycast(ray, out float lenght);
        Vector3 point = ray.GetPoint (lenght);
        _aim.position = point;
    }

}
