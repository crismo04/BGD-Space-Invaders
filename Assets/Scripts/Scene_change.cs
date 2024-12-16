using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_change : MonoBehaviour
{
    public void NextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

