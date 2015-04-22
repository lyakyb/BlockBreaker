﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
	float mousePositionInBlocks;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		mousePositionInBlocks = Input.mousePosition.x / Screen.width * 16;
		var paddlePosition = new Vector3 (0.5f, this.transform.position.y, 0f);

		paddlePosition.x = Mathf.Clamp (mousePositionInBlocks, 0.5f, 15.5f);

		this.transform.position = paddlePosition;
	}
}
