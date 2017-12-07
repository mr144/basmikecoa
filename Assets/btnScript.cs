using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Kembali(string levelName)
	{
		Application.LoadLevel(levelName);
	}
}
