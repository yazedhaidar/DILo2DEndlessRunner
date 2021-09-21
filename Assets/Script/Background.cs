using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
   [Header("Background")]
	public Renderer BG;
	public float speedBG;

	private float startPosX;
	private Transform cameraMain;

	void Start()
	{
        cameraMain = Camera.main.transform;
		startPosX = cameraMain.position.x;
		BG.sortingOrder = -5;
	}

	void Update()
	{
		float x = cameraMain.position.x - startPosX;

		if (BG != null)
		{
			float offset = (x * speedBG) % 1;
			BG.material.mainTextureOffset = new Vector2(offset, BG.material.mainTextureOffset.y);
		}
	}
}
