using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuitScript : MonoBehaviour
{
    public TMP_Text tmp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        tmp.color = Color.black;
    }

    void OnMouseExit()
    {
        tmp.color = Color.white;
    }

    void OnMouseDown()
    {
        //Quit Game
        Application.Quit();
    }

}