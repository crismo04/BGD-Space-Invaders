﻿using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float minPosX;
    public float maxPosX;

    public float moveDistance = 1f;

    bool isMovingRight = true;


    public float timeStep = 1f;
    public float countdown;
	
	// I added a switch to try both methods
	public bool isUsingCountdown = true;

    // Use this for initialization
    void Start()
    {
		if (isUsingCountdown)
		{
			countdown = timeStep;
		}
		else
		{	
			// Invoke repeating will be called once after timeStep (2nd parameter) amount,
			// and then repeatedly every timeStep (3rd parameter) amount
			//InvokeRepeating("Move", timeStep, timeStep);
			InvokeRepeating("Move", timeStep, timeStep);
		}
    }

    // Update is called once per frame
    void Update()
    {
		if (isUsingCountdown)
		{
			countdown -= Time.deltaTime;

			if (countdown <= 0)
			{
				Move();
				countdown = timeStep;
			}
		}
    }

    void Move()
    {
        if (isMovingRight)
        {
            // Moving right
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos + new Vector3(moveDistance, 0f);
            transform.position = newPos;

            // If aliens group reached the right-most edge, flip their direction
            if (transform.position.x >= maxPosX)
            {
                isMovingRight = false;
                //TODO add movement to X vertex
                //TODO add triger when it reach the botton
            }
        }
        else
        {
            // Moving left
            Vector3 currentPos = transform.position;
            Vector3 newPos = currentPos - new Vector3(moveDistance, 0f);
            transform.position = newPos;

            // If aliens group reached the left-most edge, flip their direction
            if (transform.position.x <= minPosX)
            {
                isMovingRight = true;
            }
        }
    }
}