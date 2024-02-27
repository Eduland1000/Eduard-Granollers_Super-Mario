using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOverManager : MonoBehaviour
{
    public void LoadFirstLevel(){
        SceneManager.LoadScene("World 1");
    } 

    public void LoadMenu(){
        SceneManager.LoadScene("Main Scren");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
