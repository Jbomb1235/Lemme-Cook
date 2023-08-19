using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AssembleFood : MonoBehaviour
{
    public bool active;
    public bool keydown;
    public bool endkey;
    public GameObject Player;
    public string placedfood;
    public string placedfood2;
    public string placedfood3;


    public string[] tags;
    public GameObject[] firstfoodarray;
    public GameObject[] secondfoodarray;
    public GameObject[] thirdfoodarray;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(firstfoodarray);
    }
    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0;i<12;i++)
        {
            if (placedfood == tags[i])
        {
                firstfoodarray[i].SetActive(true);
                continue;
        }
                firstfoodarray[i].SetActive(false);
        }
        for(int i = 0;i<12;i++)
        {
            if (placedfood2 == tags[i])
        {
                secondfoodarray[i].SetActive(true);
                continue;
        }
                secondfoodarray[i].SetActive(false);
        }
        for(int i = 0;i<12;i++)
        {
            if (placedfood3 == tags[i])
        {
                thirdfoodarray[i].SetActive(true);
                continue;
        }
                thirdfoodarray[i].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            keydown = true;
        }
        else
        {
            keydown = false;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            endkey = true;
            Debug.Log("EndKey");
        }
        else
        {
            endkey = false;
        } 
        if (active && keydown)
        {
            Debug.Log(Player.tag);
            if (placedfood == "")
            {
                placedfood = Player.tag;
                Player.tag = "Player";
                Debug.Log(Player.tag);
            }
            else if (placedfood2 == "")
            {
                placedfood2 = Player.tag;
                Player.tag = "Player";
            }
            else if (placedfood3 == "")
            {
                placedfood3 = Player.tag;
                Player.tag = "Player";
            }

        }
            if (placedfood == "Player")
            {
                placedfood = "";
            }
            if (placedfood2 == "Player")
            {
                placedfood2 = "";
            }
            if (placedfood3 == "Player")
            {
                placedfood3 = "";
            }

            if (active && endkey)
            {
                Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
                if ((placedfood == "Patty" && placedfood2 == "Buns") || (placedfood == "Buns" && placedfood2 == "Patty"))
                {
                    Debug.Log("I want to stab Harry");
                    Player.tag = "Borgir";
                    placedfood = "";
                    placedfood2 = "";
                }
                if ((placedfood == "Borgir" && placedfood2 == "Cheese") || (placedfood == "Cheese" && placedfood2 == "Borgir"))
                {
                    Debug.Log("I want to stab Harry but cheesy");
                    Player.tag = "CheesyBorgy";
                    placedfood = "";
                    placedfood2 = "";
                }
            if ((placedfood == "CheesyBorgy" && placedfood2 == "Tomato" && placedfood3 == "Lettuce") || (placedfood == "Tomato" && placedfood2 == "CheesyBorgy" && placedfood3 == "Lettuce") || (placedfood == "Tomato" && placedfood2 == "Lettuce" && placedfood3 == "CheesyBorgy")|| (placedfood == "CheesyBorgy" && placedfood2 == "Lettuce" && placedfood3 == "Tomato") || (placedfood == "Lettuce" && placedfood2 == "CheesyBorgy" && placedfood3 == "Tomato") || (placedfood == "Lettuce" && placedfood2 == "Tomato" && placedfood3 == "CheesyBorgy"))
            {
                Debug.Log("I want to stab Harry but cheesy");
                Player.tag = "CheesyBorgyWithVeggie";
                placedfood = "";
                placedfood2 = "";
                placedfood3 = "";
            }
            if (placedfood == "Borgir" && placedfood2 == "Borgir")
            {
                Debug.Log("I want to stab Harry");
                Player.tag = "DoubleBorgir";
                placedfood = "";
                placedfood2 = "";
            }
            if (placedfood == "CheesyBorgy" && placedfood2 == "CheesyBorgy")
            {
                Debug.Log("I want to stab Harry");
                Player.tag = "DoubleCheesyBorgy";
                placedfood = "";
                placedfood2 = "";
            }
            if (placedfood == "CheesyBorgyWithVeggie" && placedfood2 == "CheesyBorgyWithVeggie")
            {
                Debug.Log("I want to stab Harry");
                Player.tag = "DoubleCheesyBorgyWithVeggie";
                placedfood = "";
                placedfood2 = "";
            }
            endkey = false;
            active = false;
            }
        if (Input.GetKeyDown(KeyCode.X))
        {
            placedfood = "";
            placedfood2 = "";
            placedfood3 = "";

        }

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            active = true;
        }
        if (other.gameObject.CompareTag("Player"))
        {
            active = true;
        }
    }
   private void OnTriggerExit2D(Collider2D other)
   {
        if (other.gameObject.name=="Player")
        {
            active = false;
        }
   }
}
