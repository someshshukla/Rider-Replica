using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

	public void SelectScene1()
	{
        SceneManager.LoadScene(2);
    }

    public void SelectScene2()
    {
        SceneManager.LoadScene(3);
    }

    public void SelectScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void SelectScene4()
    {
        SceneManager.LoadScene(5);
    }
}
