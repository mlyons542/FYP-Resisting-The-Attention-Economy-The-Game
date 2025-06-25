using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DoorScript : MonoBehaviour
{
    public Transform player;
    public int DoorCounter = 0;
    public Transform startPos;
    //private string CurrentScene;
    public Camera MainCamera;
    /*
    public Camera DC1;
    public Camera DC2;
    public Camera DC3;
    public Camera LC1;
    public Camera LC2;
    public Camera LC3;
    */
    
    public Image bg;
    public TextMeshProUGUI DT1;
    public TextMeshProUGUI DT2;
    public TextMeshProUGUI DT3;
    protected MeshRenderer ms;
    

    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        /*
        DC1.enabled = false;
        DC2.enabled = false;
        DC3.enabled = false; 
        LC1.enabled = false;
        LC2.enabled = false;
        LC3.enabled = false;
        */
        
        bg.enabled = false;
        DT1.enabled = false;
        DT2.enabled = false;
        DT3.enabled = false;

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

        //bg.enabled = true;

        if (DoorCounter == 0)
        {
            /*
            SceneManager.LoadScene("DoorScene1");
            CurrentScene = "DoorScene1";
            */
            /*
            MainCamera.enabled = false;
            DC1.enabled = true;
            */
            
            DT1.enabled = true;
            bg.enabled = true;
            ms.enabled = true;
            

            //DoorCounter++;
            

        }
        if (DoorCounter == 1)
        {
            /*
            SceneManager.LoadScene("DoorScene2");
            CurrentScene = "DoorScene2";
            */
            /*
            MainCamera.enabled = false;
            DC2.enabled = true;
            */

            //DT2.enabled = true;
            DT2.enabled = true;
            bg.enabled = true;
            ms.enabled = true;


            //DoorCounter++;
        }
        if (DoorCounter == 2)
        {
            /*
            SceneManager.LoadScene("DoorScene3");
            CurrentScene = "DoorScene3";
            */
            /*
            MainCamera.enabled = false;
            DC3.enabled = true;
            */
            //DT3.enabled = true;
            DT3.enabled = true;
            bg.enabled = true;
            ms.enabled = true;
            DoorCounter = 0;

            //DoorCounter = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("x"))
            //SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
            //SceneManager.UnloadSceneAsync(CurrentScene);
            //DoorCounter++;
            /*
            MainCamera.enabled = true;
            DC1.enabled = false;
            DC2.enabled = false;
            DC3.enabled = false;
            */
            bg.enabled = false;
            DT1.enabled = false;
            DT2.enabled = false;
            DT3.enabled = false;
            ms.enabled = false;

        player.position = startPos.position;

    }
    
}
