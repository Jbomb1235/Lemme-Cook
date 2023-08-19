using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinet : MonoBehaviour
{
    public GameObject player;
    public bool exit;
    public bool entor;
    public string gametag;
    private Transform childObj;
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
    public string[] tags;
    public GameObject[] foodarray;
    // Start is called before the first frame update
    void Start()
    {
        tags[0] = "Beef";
        tags[1] = "Buns";
        tags[2] = "Borgir";
        tags[3] = "Cheese";
        tags[4] = "CheesyBorgy";
        tags[5] = "DoubleBorgir";
        tags[6] = "DoubleCheesyBorgy";
        tags[7] = "DoubleCheesyBorgyWithVeggie";
        tags[8] = "Lettuce";
        tags[9] = "Patty";       
        tags[10] = "Tomato";
        tags[11] = "CheesyBorgyWithVeggie";

        for(int i = 0;i<12;i++){
        foodarray[i] = gameObject.transform.GetChild(i).gameObject;
        }
    }
    // Update is called once per frame
    void Update()
    {
        for(int i = 0;i<12;i++)
        {
            if (gameObject.tag == tags[i])
        {
                foodarray[i].SetActive(true);
                continue;
        }
                foodarray[i].SetActive(false);
        }

        gametag = gameObject.tag;
        if (Input.GetKeyDown(KeyCode.E) && exit)
        {
            player.tag = gameObject.tag;
            Debug.Log("cabinet");
            gameObject.tag = "cabinet";
            exit = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && entor && gameObject.tag=="cabinet")
        {   
            gameObject.tag = player.tag;
            player.tag = "Player";
            childObj = transform.Find(gameObject.tag);
            Debug.Log(childObj);
            Debug.Log(player.tag);
            entor = false;
        }
        if(gameObject.tag == "Player")
        {
            gameObject.tag = "cabinet";
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player") && gameObject.tag != "cabinet")
        {
            exit = true;
        }
        if (!(other.gameObject.CompareTag("Player") && gameObject.tag != "cabinet"))
        {
            entor = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {        
            exit = false;
            entor = false;   
    }
        
}