using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    
    public string[] sceneNamesToLoad;

    
    void Awake()
    {
        
        foreach (string sceneName in sceneNamesToLoad)
        {
            
            if (!SceneManager.GetSceneByName(sceneName).isLoaded)
            {
                
                SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
            }
        }
    }
}