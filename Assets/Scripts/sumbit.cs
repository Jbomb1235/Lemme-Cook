using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sumbit : MonoBehaviour
{
    public bool active;
    public bool keydown;
    public int score;
    public GameObject Player;
    public string tag;
    public ParticleSystem particleSystem;

    public bool foodOne;
    public bool foodTwo;
    public bool foodThree;
    public bool foodFour;
    public bool foodFive;
    public bool foodSix;

    public GameObject ifoodOne;
    public GameObject ifoodTwo;
    public GameObject ifoodThree;
    public GameObject ifoodFour;
    public GameObject ifoodFive;
    public GameObject ifoodSix;

    public int num;
    public Text foodLeft;
    public GameObject Winner;
    public int i = 5;
    public float timepast;
    public bool ended = false;
    public int stars;
    public bool foodIncomplete = false;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject starHolder;
    public GameObject Donezo;

    public GameObject Menu;
    public GameObject Next;

    public bool lvl1;
    public bool lvl2;
    public bool lvl3;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem.enableEmission = false;

    }

    // Update is called once per frame
    void Update()
    {        
        if(ended==false)
        {
            timepast+=Time.deltaTime;
        }
        if(i == 0)
        {
            ended=true;
        }
        if (ended)
        {
            Donezo.SetActive(false);
            Player.SetActive(false);
            Menu.SetActive(true);
            Next.SetActive(true);
        }
        if (lvl1 == true)
        {
            if (ended && timepast < 270)
            {
                stars = 3;
                starHolder.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else if (ended && timepast < 300)
            {
                stars = 2;
                starHolder.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
            }
            else if (ended && timepast > 300)
            {
                stars = 1;
                starHolder.SetActive(true);
                star1.SetActive(true);
            }
        }
        if (lvl2 == true)
        {
            if (ended && timepast < 350)
            {
                stars = 3;
                starHolder.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else if (ended && timepast > 350)
            {
                stars = 2;
                starHolder.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
            }
            else if (ended && timepast < 380)
            {
                stars = 1;
                starHolder.SetActive(true);
                star1.SetActive(true);
            }
        }
        if (lvl3 == true)
        {
            if (ended && timepast < 450)
            {
                stars = 3;
                starHolder.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
            }
            else if (ended && timepast > 450)
            {
                stars = 2;
                starHolder.SetActive(true);
                star1.SetActive(true);
                star2.SetActive(true);
            }
            else if (ended && timepast > 480)
            {
                stars = 1;
                starHolder.SetActive(true);
                star1.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && active)
        {
            keydown = true;
        }
        else
        {
            keydown = false;
        }
        /*if (active && keydown)
        {
            score += 50;
            active = false;
            Player.tag = "Player";
        }*/
        if (foodIncomplete==false)
        {
            random();
            foodIncomplete = true;
        }
        if (num == 1)
        {
            foodOne = true;
            ifoodOne.SetActive(true);
        }
        if (num == 2)
        {
            foodTwo = true;
            ifoodTwo.SetActive(true);
        }
        if (num == 3)
        {
            foodThree = true;
            ifoodThree.SetActive(true);
        }
        if (num == 4)
        {
            foodFour = true;
            ifoodFour.SetActive(true);
        }
        if (num == 5)
        {
            foodFive = true;
            ifoodFive.SetActive(true);
        }
        if (num == 6)
        {
            foodSix = true;
            ifoodSix.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            keydown = true;
        }
        else
        {
            keydown = false;
        }
        if (active && keydown && foodOne && Player.tag == "Borgir")
        {
            particleSystem.enableEmission = true;
            score += 50;
            active = false;
            Player.tag = "Player";
            ifoodOne.SetActive(false);
            foodOne = false;
            Debug.Log("God");
            foodIncomplete = false;
            Invoke("dragon", 3f);
            i = i - 1;
            foodLeft.text = i.ToString();
        }
        if (active && keydown && foodTwo && Player.tag == "CheesyBorgy")
        {
            particleSystem.enableEmission = true;
            score += 50;
            active = false;
            Player.tag = "Player";
            ifoodTwo.SetActive(false);
            foodTwo = false;
            Debug.Log("Is");
            foodIncomplete = false;
            Invoke("dragon", 3f);
            i = i - 1;
            foodLeft.text = i.ToString(); 
        }
        if (active && keydown && foodThree && Player.tag == "CheesyBorgyWithVeggie")
        {
            particleSystem.enableEmission = true;
            score += 50;
            active = false;
            Player.tag = "Player";
            ifoodThree.SetActive(false);
            foodThree = false;
            Debug.Log("Dead");
            foodIncomplete = false;
            Invoke("dragon", 3f);
            i = i - 1;
            foodLeft.text = i.ToString();
        }
        if (active && keydown && foodFour && Player.tag == "DoubleBorgir")
        {
            particleSystem.enableEmission = true;
            score += 50;
            active = false;
            Player.tag = "Player";
            ifoodFour.SetActive(false);
            foodFour = false;
            Debug.Log("blood");
            foodIncomplete = false;
            Invoke("dragon", 3f);
            i = i - 1;
            foodLeft.text = i.ToString();
        }
        if (active && keydown && foodFive && Player.tag == "DoubleCheesyBorgy")
        {
            particleSystem.enableEmission = true;
            score += 50;
            active = false;
            Player.tag = "Player";
            ifoodFive.SetActive(false);
            foodFive = false;
            Debug.Log("Is");
            foodIncomplete = false;
            Invoke("dragon", 3f);
            i = i - 1;
            foodLeft.text = i.ToString();
        }
        if (active && keydown && foodSix && Player.tag == "DoubleCheesyBorgyWithVeggie")
        {
            particleSystem.enableEmission = true;
            score += 50;
            active = false;
            Player.tag = "Player";
            ifoodSix.SetActive(false);
            foodSix = false;
            Debug.Log("Fuel");
            foodIncomplete = false;
            Invoke("dragon", 3f);
            i = i - 1;
            foodLeft.text = i.ToString();
        }
        if (score==250)
        {
            Winner.SetActive(true);
        }
        else
        {
            Winner.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            active = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            active = true;
            Debug.Log("AAAAAAAAAAAAAAAAAAAAA");
        }
    }
    void random()
    {
        num = Random.Range(1, 7);
        Debug.Log(num);
    }
    void dragon()
    {
        particleSystem.enableEmission = false;
    }
}
