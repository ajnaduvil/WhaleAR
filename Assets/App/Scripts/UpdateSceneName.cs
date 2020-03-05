using AVR.Utils.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Updates the changed scene name to text
/// </summary>
public class UpdateSceneName : MonoBehaviour
{
    public SceneSwitcher sceneSwitcher;
    public Text sceneNameText;
    // Start is called before the first frame update
    void Start()
    {
        sceneSwitcher.sceneChanged += (sceneName) => { sceneNameText.text = sceneName; };
    }

}
