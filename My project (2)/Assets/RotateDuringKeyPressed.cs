using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDuringKeyPressed : MonoBehaviour
{   
    public float speed = 5.0f;
    public KeyCode key = KeyCode.R;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(key))
            transform.Rotate(0.0f,speed,0.0f);
            Debug.Log("Le cube tourne");
    }
}
