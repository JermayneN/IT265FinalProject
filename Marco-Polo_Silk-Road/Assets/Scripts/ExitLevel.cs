using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour {
    public Button Back;
    // Use this for initialization
    void Start () {
        Back = Back.GetComponent<Button>();
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
