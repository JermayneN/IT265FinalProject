using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button exittext;  
	// Use this for initialization
	void Start () {

        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exittext = exittext.GetComponent<Button>();
        quitMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exittext.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exittext.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
