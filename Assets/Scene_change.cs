using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change : MonoBehaviour
{
    public void NextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
