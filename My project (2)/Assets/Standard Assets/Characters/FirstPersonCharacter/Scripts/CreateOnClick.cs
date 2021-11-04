using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnClick : MonoBehaviour
{

    public GameObject customGameObject1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            generateEnviroment();
        }
    }


    void generateEnviroment()
    {
        GameObject myInstantiatedGameObject = GameObject.Instantiate(customGameObject1);

        myInstantiatedGameObject.transform.position = new Vector3(0F, 0F, 2F);

        Renderer rend = myInstantiatedGameObject.GetComponent<Renderer>();
        rend.material.SetColor("_Color", Color.blue);

        Debug.Log("Nouveau Object créé");
    }
}



