using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move left
        if (Input.GetKey("a"))
            transform.Translate(Vector3.left * Time.deltaTime * 4);
        //Move right
        if (Input.GetKey("d"))
            transform.Translate(Vector3.right * Time.deltaTime * 4);
    }
}
