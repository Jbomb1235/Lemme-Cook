using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodRequest : MonoBehaviour
{
    public bool foodOne;
    public bool foodTwo;
    public bool foodThree;
    public bool foodFour;
    public bool foodFive;
    public bool foodSix;

    public bool foodIncomplete = false;

    public float startTime;
    public float TimeRemaining;
    public bool timor;

    public int num;

    //public int num;
    // Start is called before the first frame update
    void Start()
    {
        timor = false;
        //random();
    }

    // Update is called once per frame
    void Update()
    {
        /* if (startTime > 0)
         {
             startTime -= Time.deltaTime;
             timor = true;
         }
         if (timor&&TimeRemaining>0)
         {
             TimeRemaining -= Time.deltaTime;
         }
         if(TimeRemaining < 0)
         {
             TimeRemaining = 45;
         }*/

        if (foodIncomplete==false)
        {
            random();
            foodIncomplete = true;
        }
        if (num == 1)
        {
            
        }
        
    }
    void random()
    {
        num = Random.Range(1,7);
        Debug.Log(num);
    }
}
