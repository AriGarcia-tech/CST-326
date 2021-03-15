using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //Reset() Tell E-manager to restart, shield to spawn, instantiate player player lives


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SceneManager.LoadScene("DemoScene");
            //Don'tDestroyOnLoad
        }
        //if(playerDestroyed = true){
        //SceneManager.LoadScene("Credits"); }
    }
}
