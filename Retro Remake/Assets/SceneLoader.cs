using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void ButtonTest()
    {
        Debug.Log("it works.");
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
