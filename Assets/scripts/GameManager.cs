using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public void endGame()
    {
        bool isOver = false;

        if (!isOver)
        {
            Debug.Log("gameOver()");
            Invoke("restart", 2f);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
