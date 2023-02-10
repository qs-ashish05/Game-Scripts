using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleted : MonoBehaviour
{
    
    public GameObject completeobj;
    void OnCollisionEnter(Collision col){

         completeobj.SetActive(true);
     }
}
