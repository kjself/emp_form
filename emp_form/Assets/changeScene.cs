using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void change(Scene scene)
    {
        string s = scene.ToString();
        SceneManager.LoadScene(s);
    }
}
