using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static : MonoBehaviour
{
    public Material staticmat;
    System.Random rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        staticmat.mainTextureOffset=(new Vector2((float)rand.NextDouble(), (float)rand.NextDouble()));
    }
}
