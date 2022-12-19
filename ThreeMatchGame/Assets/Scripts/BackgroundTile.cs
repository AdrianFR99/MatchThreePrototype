using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] dots;
    
    void Start()
    {
        intialize();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void intialize()
    {
        int dotToUse = Random.Range(0, dots.Length);
        GameObject dot = Instantiate(dots[dotToUse],transform.position,Quaternion.identity);
        dot.transform.parent=this.transform;
        dot.name= dot.name+this.gameObject.name;

    }
}
