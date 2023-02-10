using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector3 offset;
    void Update()
    {
        if(player == null){
            return;
        }
        else {
        transform.position=Vector3.Lerp(transform.position,player.position+offset,Time.time);
        }
    }
}
