using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public Sprite[] menuFrames;
    public Sprite[] playFrames;
    public Sprite[] exitFrames;

    public float changeMenuFrameDelay;
    public Image menu;
    public Image play;
    public Image exit;
    int frame = 0;

	void Start () {
        ChangeFrame();
	}

    public void OnExitClick()
    {
        Application.Quit();    
    }

    public void OnPlayClick()
    {
        SceneManager.LoadScene(1);
    }

    void ChangeFrame() {
        Invoke("ChangeFrame", changeMenuFrameDelay);
        frame = (frame + 1) % menuFrames.Length;
        menu.sprite = menuFrames[frame];
        play.sprite = playFrames[frame];
        exit.sprite = exitFrames[frame];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
