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
    }
}
