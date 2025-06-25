using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LaptopScript : MonoBehaviour
{
    public Transform player;
    public int LaptopCounter = 0;
    public Transform startPos;

    public Camera MainCamera;
    public Image bg;
    public TextMeshProUGUI LT1;
    public TextMeshProUGUI LT2;
    public TextMeshProUGUI LT3;
    protected MeshRenderer ms;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        bg.enabled = false;
        LT1.enabled = false;
        LT2.enabled = false;
        LT3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && Vector3.Distance(player.position, transform.position) < 4)
            //Display dialogue
            SceneChanger();
    }

    public void SceneChanger()
    {
        //DontDestroyOnLoad(this.gameObject);

        if (LaptopCounter == 0)
        {
            /*
            SceneManager.LoadScene("LaptopScene1");
            */
            //LaptopCounter++;
            LT1.enabled = true;
            bg.enabled = true;
            ms.enabled = true;
        }

        if (LaptopCounter == 1)
        {
            /*
            SceneManager.LoadScene("LaptopScene2");
            */
            //LaptopCounter++;
            LT2.enabled = true;
            bg.enabled = true;
            ms.enabled = true;
        }

        if (LaptopCounter == 2)
        {
            /*
            SceneManager.LoadScene("LaptopScene3");
            */
            //LaptopCounter = 0;
            LT3.enabled = true;
            bg.enabled = true;
            ms.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("x"))
            /*
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
            */
            bg.enabled = false;
            LT1.enabled = false;
            LT2.enabled = false;
            LT3.enabled = false;
            ms.enabled = false;

        player.position = startPos.position;
            
    }
}
