using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Scene : MonoBehaviour
{
    public void Load1()
    {
        SceneManager.LoadScene(1);
    }
    public void Load2()
    {
        SceneManager.LoadScene(2);
    }
    public void Load3()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadBack()
    {
        SceneManager.LoadScene(0);
    }
}
