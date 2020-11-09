using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalBGMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private static GlobalBGMusic instance = null;

    public static GlobalBGMusic Instance
    {
        get 
        { 
            return instance; 
        }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            this.gameObject.SetActive(false);
            //Destroy(this.gameObject);
            return;
        }

        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);

        
    }
    // Update is called once per frame
    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "SampleGame" || sceneName == "TutorialStage1" || sceneName == "Stage 4" || sceneName == "MoveToNextStage")
        {
            this.gameObject.SetActive(false);
        }

        else
        {
            this.gameObject.SetActive(true);
        }
    }
}
