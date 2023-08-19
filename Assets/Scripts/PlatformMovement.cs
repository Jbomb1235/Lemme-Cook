using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject Platform;
    public bool forward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Platform.name == "Platform1"|| Platform.name == "Platform4" )
        {
            if (forward)
            {
                if (Platform.transform.position.x != 30)
                {
                    Platform.transform.position += new Vector3((float)0.2, 0, 0);
                }
                if (Platform.transform.position.x >= 30)
                {
                    forward = false;
                }
            }
            if (forward == false)
            {
                if (Platform.transform.position.x != 1)
                {
                    Platform.transform.position += new Vector3((float)-0.2, 0, 0);
                }
                if (Platform.transform.position.x <= 1)
                {
                    forward = true;
                }
            }
        }
        if (Platform.name == "Platform2" || Platform.name == "Platform5")
        {
            if (forward)
            {
                if (Platform.transform.position.x != 8)
                {
                    Platform.transform.position += new Vector3((float)0.2, 0, 0);
                }
                if (Platform.transform.position.x >= 8)
                {
                    forward = false;
                }
            }
            if (forward == false)
            {
                if (Platform.transform.position.x != -21)
                {
                    Platform.transform.position += new Vector3((float)-0.2, 0, 0);
                }
                if (Platform.transform.position.x <= -21)
                {
                    forward = true;
                }
            }
        }
        if (Platform.name == "Platform3")
        {
            if (forward)
            {
                if (Platform.transform.position.x != 19)
                {
                    Platform.transform.position += new Vector3((float)0.2, 0, 0);
                }
                if (Platform.transform.position.x >= 19)
                {
                    forward = false;
                }
            }
            if (forward == false)
            {
                if (Platform.transform.position.x != -10)
                {
                    Platform.transform.position += new Vector3((float)-0.2, 0, 0);
                }
                if (Platform.transform.position.x <= -10)
                {
                    forward = true;
                }
            }
        }
    }
}
