using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitApp : MonoBehaviour {
    public Button btn_keluar;

	// Use this for initialization
	void Start () {
        Button btn = btn_keluar.GetComponent<Button>();
        btn.onClick.AddListener(ExitOnClick);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void ExitOnClick()
    {
        Application.Quit();
    }
}
