using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
   // Use this for initialization
    void Start () 
    {
       
    }
    
    // Update is called once per frame
    void Update ()
    {
        ChangeScene();
    }
 
    private void ChangeScene()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        { 
            SceneManager.LoadScene("OPScene");
            
        }
         
           
        
       
    }
}
