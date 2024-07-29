using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataBase.LoadData();
    }
 public void ClickPlayButton3(){
    SceneManager.LoadScene("Level03");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
