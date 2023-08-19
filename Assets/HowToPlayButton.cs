using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HowToPlayButton : MonoBehaviour
{
    public int step=0;
    public GameObject cabinet;
    public GameObject FoodCreatorInator;
    public GameObject Oven;
    public GameObject Oven2;
    public GameObject Oven3;
    public GameObject Submit;
    public GameObject Button1;
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (step == 1)
        {
            cabinet.SetActive(false);
            Oven.SetActive(true);
            Oven2.SetActive(true);
            Oven3.SetActive(true);
            txt.text = "The oven has three states depicted above. The first state is the oven being empty. Pressing \"E\" with meat turns on the oven to the second state. The second state lasts 10 seconds and cooks the meat. The last state happens next and you can take out the finished product with \"E\".";
        }
        if (step == 2)
        {
            Oven.SetActive(false);
            Oven2.SetActive(false);
            Oven3.SetActive(false);
            FoodCreatorInator.SetActive(true);
            txt.text = "The FoodCreatorInator creates food combining all the food in the creator with the \"F\" key. You place all the food in with the \"E\" key. The Recipes build off eachother in the creator. So you would create a burger and then to make a cheese burger you would place the finished burger in with cheese. To empty the creator press \"X\".";
        }
        if (step == 3)
        {
            FoodCreatorInator.SetActive(false);
            Submit.SetActive(true);
            Button1.SetActive(true);
            //Button2.SetActive(true);
            txt.text = "To Submit food place the finished food in the object with \"E\". The food you need to make is on the the blue card in the corner";
        }
        if (step >= 4)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void NextHowToPlay()
    {
        step = step + 1;

    }
}
