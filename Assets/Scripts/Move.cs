using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 v = transform.position; 
        if(Input.GetKeyUp(KeyCode.UpArrow)){
            v.y += 1;
        }
        if(Input.GetKeyUp(KeyCode.DownArrow)){
            v.y -= 1;
        } 
        if(Input.GetKeyUp(KeyCode.RightArrow)){
            v.x += 1;
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow)){
            v.x -= 1;
        }
        transform.position = v;
    }
}
