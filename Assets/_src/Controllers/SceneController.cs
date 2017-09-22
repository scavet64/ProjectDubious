using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public static SceneController Instance { get; set; }
    private AsyncOperation async;

    /// <summary>
    /// This is the main method that instantiates the Level Manager class
    /// Only a single instance can exist. This will ensure that there are no duplicates
    /// when reloading a scene.
    /// </summary>
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            //StartLoading();
        }
    }

    private void Update()
    {
        if (async != null && async.progress >= 0.9f)
        {
            async.allowSceneActivation = true;
        }
    }

    public void StartLoading()
    {
        StartLoading("Menu");
    }

    public void StartLoading(string name)
    {
        StartCoroutine(LoadAsyncLevel(name));
    }

    /// <summary>
    /// Load the level with the given name
    /// </summary>
    /// <param name="name">Name.</param>
    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        SceneManager.LoadSceneAsync(name);
    }

    IEnumerator LoadAsyncLevel(string name)
    {
        Debug.Log("New Level load: " + name);
        async = SceneManager.LoadSceneAsync(name);
        async.allowSceneActivation = false;
        yield return async;
    }

    /// <summary>
    /// Loads the main game.
    /// </summary>
    public void LoadMainGame()
    {
        SceneManager.LoadSceneAsync("01Level");
        //MenuScreen.active = false;
    }

    /// <summary>
    /// Quits the request.
    /// </summary>
    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}
