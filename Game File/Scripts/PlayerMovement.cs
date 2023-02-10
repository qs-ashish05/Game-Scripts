using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float sensitivity=0.03f;
    [SerializeField]
    private float speed=1.0f;
    private Touch touch;
    bool freeze=true;
    Rigidbody rb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        StartCoroutine(StartTimer());
    }
    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(3f);
        freeze=false;
    }
    private void OnTriggerEnter(Collider other) 
    {
        freeze=true;
        rb.useGravity=true;
    }
    private void OnCollisionEnter(Collision other) 
    {
        rb.useGravity=false;
        rb.isKinematic = true;
    }
    void Update()
    {
        if(!freeze)
        {
            rb.velocity=new Vector3(0,rb.velocity.y,speed);
            if(Input.touchCount>0)
            {
                rb.useGravity=false;
                touch=Input.GetTouch(0);
                if(touch.phase== TouchPhase.Moved)
                {
                    transform.position=Vector3.Lerp(transform.position, new Vector3(transform.position.x,transform.position.y+touch.deltaPosition.y*sensitivity,transform.position.z),Time.time);
                }
            }
            else
            {
                rb.useGravity=true;
            }
        }
    }
}