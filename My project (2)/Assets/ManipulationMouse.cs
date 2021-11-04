using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulationMouse : MonoBehaviour
{   
    private float movementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            {
                Debug.Log(mousePos.x);
                Debug.Log(mousePos.y);
                transform.position = transform.position + new Vector3(mousePos.x * movementSpeed * Time.deltaTime, mousePos.y * movementSpeed * Time.deltaTime, 0);
                Debug.Log(transform.position);
            }
        }
    }
}
