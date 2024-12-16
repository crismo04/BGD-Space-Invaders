using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Reference to the original prefab to instatiate
    public GameObject projectilePrefab;
    
	// Reference to the AudioSource component on the player
	public AudioSource sfxPlayer;

    // Add the scene script to update bullet number
    private Control_numbers control;

    // Start is called before the first frame update
    void Start()
    {
        control = FindObjectOfType<Control_numbers>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    void Shoot()
    {	
		// We instantiate the prefab at the same position as the player,
        // since this script is on the player GameObject
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        sfxPlayer.Play();
        control.Update_bullet();
    }
}
