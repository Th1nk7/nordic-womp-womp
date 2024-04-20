using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFire : MonoBehaviour
{
    public Transform transform;
    public BoxCollider2D bc;


    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "CameraFireCol"){
            transform.position = new Vector2(transform.position.x,transform.position.y+1);
            Debug.Log("aaa");
        }
    }
}
