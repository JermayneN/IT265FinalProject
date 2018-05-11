using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour {

    
    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Back;
    // Use this for initialization
    void Start () {
       
        Level1 = Level1.GetComponent<Button>();
        Level2 = Level2.GetComponent<Button>();
        Level3 = Level3.GetComponent<Button>();
        Back = Back.GetComponent<Button>();
        
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
    public void StartLevel1()
    {
        SceneManager.LoadScene(2);

    }
    public void StartLevel2()
    {
        SceneManager.LoadScene(3);
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene(4);
    }
}










    
