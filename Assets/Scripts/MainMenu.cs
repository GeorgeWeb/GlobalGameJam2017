using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SceneManager.LoadScene("Scratch", LoadSceneMode.Single);

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
