using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public void loadTwoPlayer()
    {
        SceneManager.LoadScene("pong basic");
    }
    public void loadOnePlayer()
    {
        SceneManager.LoadScene("pong random");
    }
}
