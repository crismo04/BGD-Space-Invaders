using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Control_numbers : MonoBehaviour
{
    //number of bullets
    public int ammo = 50;
    // Reference to the UI Text objects
    public TMP_Text alienCountText;
    public TMP_Text bulletCountText;

    public void Update_alien()
    {

        // Find all objects with the "Alien" tag
        GameObject[] aliens = GameObject.FindGameObjectsWithTag("Alien");

        // Get the count
        int alienCount = aliens.Length -1;

        // Update the UI Text
        Debug.Log("Number of aliens in the scene: " + alienCount);
        alienCountText.text = "Aliens left: " + alienCount;

        if (alienCount <= 0)
        {
            SceneManager.LoadScene("Winner");
        }
    }

    public void Update_bullet()
    {
        ammo--;
        Debug.Log("Number of bullets: " + ammo);
        bulletCountText.text = "Bullets left: " + ammo;

        if (ammo <= 0)
        {
            SceneManager.LoadScene("Loser");
        }
    }
}

