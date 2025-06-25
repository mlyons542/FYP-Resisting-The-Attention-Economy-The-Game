using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EscapeScript : MonoBehaviour
{
    public Transform player;
    public Transform startPos;
    public Image otherIM;
    public TextMeshProUGUI DT1;
    public TextMeshProUGUI DT2;
    public TextMeshProUGUI DT3;
    public TextMeshProUGUI LT1;
    public TextMeshProUGUI LT2;
    public TextMeshProUGUI LT3;
    public MeshRenderer ms;

    public LaptopScript LS;
    public DoorScript DS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("x"))
        {
            
            if (DT1.enabled ||  DT2.enabled || DT3.enabled == true)
            {
                DS.DoorCounter++;
            }  
            if (LT1.enabled || LT2.enabled || LT3.enabled == true )
            {
                LS.LaptopCounter++;
            }

            //End state
            if (DS.DoorCounter == 3)
            {
                DS.DoorCounter = 0;
                SceneManager.LoadScene("TitleScene");

            }
            if (LS.LaptopCounter == 3)
            {
                LS.LaptopCounter = 0;
                SceneManager.LoadScene("TitleScene");
            }

            //Leave canvas
            player.position = startPos.position;
            DT1.enabled = false;
            DT2.enabled = false;
            DT3.enabled = false;
            LT1.enabled = false;
            LT2.enabled = false;
            LT3.enabled = false;
            otherIM.enabled = false;
            ms.enabled = false;

        }
            
    }
}
