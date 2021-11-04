using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnMouse : MonoBehaviour
{
    public Color color = Color.green;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     var renderer = GetComponent<Renderer>();
        //     renderer.material.SetColor("_Color", Color.green);
        // }

    }

    void OnMouseOver()
    {
        var renderer = GetComponent<Renderer>();
         renderer.material.SetColor("_Color", color);
    }
}
