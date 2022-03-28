using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule_behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(1*Time.deltaTime,0,0); //x,y,z
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-1*Time.deltaTime,0,0); //x,y,z
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,0,1*Time.deltaTime); //x,y,z
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,0,-1*Time.deltaTime); //x,y,z
        }

        /*if(Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Rigidbody>().velocity = transform.right * 50 * Time.deltaTime;
        }*/
        
        
        /*if(Input.GetKeyDown(KeyCode.RightArrow)){
            Debug.Log("Right Arrow pushed");
        }
        if(Input.GetKeyUp(KeyCode.RightArrow)){
            Debug.Log("Right Arrow released");
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            Debug.Log("Right Arrow being pushed");
        }

        if(Input.GetMouseButtonDown(0)){ //O: Left, 1: Right, 2: Middle
            Debug.Log("Left mouse button pushed");
        }
        if(Input.GetMouseButtonUp(0)){
            Debug.Log("Left mouse button released");
        }
        if(Input.GetMouseButton(0)){
            Debug.Log("Left mouse button being pushed");
        }*/
    }
}
