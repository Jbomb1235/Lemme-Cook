using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float timepast;
    public bool ended = false;
    public Text foodLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ended==false)
        {
            timepast+=Time.deltaTime;
        }
        if(foodLeft.ToString() == "0")
        {
            ended=true;
        }

    }
}
