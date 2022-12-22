using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    
    public void EndGame()
    {   
        if (gameHasEnded == false)
        {   
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
            
    }

    public void Restart()
        {
            SceneManager.LoadScene("Level01");
        }

    public void NextGame()
    {
        SceneManager.LoadScene("Level02");
    }
}
