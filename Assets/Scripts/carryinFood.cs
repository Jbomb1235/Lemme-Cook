using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class carryinFood : MonoBehaviour
{
    public GameObject player;
    public Text txt;
    public GameObject food1;
    public GameObject food2;
    public GameObject food3;
    public GameObject food4;
    public GameObject food5;
    public GameObject food6;
    public GameObject food7;
    public GameObject food8;
    public GameObject food9;
    public GameObject food10;
    public GameObject food11;
    public GameObject food12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.tag == "Beef")
        {
            food1.SetActive(true);
        }
        else
        {
            food1.SetActive(false);
        }
        if (player.tag == "Buns")
        {
            food2.SetActive(true);
        }
        else
        {
            food2.SetActive(false);
        }
        if (player.tag == "Borgir")
        {
            food3.SetActive(true);
        }
        else
        {
            food3.SetActive(false);
        }
        if (player.tag == "Cheese")
        {
            food4.SetActive(true);
        }
        else
        {
            food4.SetActive(false);
        }
        if (player.tag == "CheesyBorgy")
        {
            food5.SetActive(true);
        }
        else
        {
            food5.SetActive(false);
        }
        if (player.tag == "DoubleBorgir")
        {
            food6.SetActive(true);
        }
        else
        {
            food6.SetActive(false);
        }
        if (player.tag == "DoubleCheesyBorgy")
        {
            food7.SetActive(true);
        }
        else
        {
            food7.SetActive(false);
        }
        if (player.tag == "DoubleCheesyBorgyWithVeggie")
        {
            food8.SetActive(true);
        }
        else
        {
            food8.SetActive(false);
        }
        if (player.tag == "Lettuce")
        {
            food9.SetActive(true);
        }
        else
        {
            food9.SetActive(false);
        }
        if (player.tag == "Patty")
        {
            food10.SetActive(true);
        }
        else
        {
            food10.SetActive(false);
        }
        if (player.tag == "Tomato")
        {
            food11.SetActive(true);
        }
        else
        {
            food11.SetActive(false);
        }
        if (player.tag == "CheesyBorgyWithVeggie")
        {
            food12.SetActive(true);
        }
        else
        {
            food12.SetActive(false);
        }
    }
}
