using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAAAAAAA : MonoBehaviour
{
    public Vector3 size;
    private MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        size = renderer.bounds.size;
        Debug.Log(size);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
