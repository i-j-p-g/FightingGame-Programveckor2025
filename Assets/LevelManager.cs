using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    private static LevelManager instance;

    public void Awake()
    {
        
        if (instance == null)
        {

            instance = this;

            DontDestroyOnLoad(gameObject);

        }
        else
        {

            Destroy(gameObject);

        }

    }

    public void LoadLevel(string levelName)
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);

    }

}
