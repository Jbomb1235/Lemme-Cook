using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheMenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ToLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void ToLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}
