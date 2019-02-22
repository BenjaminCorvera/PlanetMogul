using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneSwitcher_Options()
    {
        SceneManager.LoadScene(1);
    }

    public void SceneSwitcher_Home()
    {
        SceneManager.LoadScene(2);
    }

    public void SceneSwitcher_Map()
    {
        SceneManager.LoadScene(3);
    }

    public void SceneSwitcher_Shop()
    {
        SceneManager.LoadScene(4);
    }

    public void SceneSwitcher_MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
