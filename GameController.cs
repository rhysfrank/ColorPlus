using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	int gridX = 8; 
	int gridY = 5;
	GameObject myCube;
	public GameObject cubePrefab;
	public GameObject [,] grid;
	public float turnTimer = 1.5f;
	Vector3 cubePosition; 
	public int playerScore; 


	// Use this for initialization
	void Start () {
		grid = new GameObject[gridX, gridY];

		for (int y = 0; y < gridY; y++) {
			for (int x = 0; x < gridX; x++) {
				cubePosition = new Vector3 (x * 2 - 8, y * 2 - 5, 0); 
				myCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);  
				myCube.GetComponent<CubeController> ().x = x; 
				myCube.GetComponent<CubeController> ().y = y;
				myCube.GetComponent<Renderer> ().material.color = maroon;

				}
			}
		}

	
	// Update is called once per frame
	void Update () {
		
	}
	public static void ProcessClick (CubeController clickedCube) {
		
	}
}
