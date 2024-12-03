using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float moveSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		// Moves the game object along the Y-axis (X is 0f), and we make the Y value into 
		// a variable so we can change the direction (up or down) and make the script reusable
		// in different situations. (can do the same for X and then it'll move in any direction you want)
        transform.Translate(new Vector3(0f, 1f) * Time.deltaTime * moveSpeed);
    }
}