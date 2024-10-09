using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeclothes : MonoBehaviour
{
    public bool head;
    public bool chest;
    public bool feet;
    public int change;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (head == true)
        {
            onoffscript.headspot += change;
        }
        if (chest == true)
        {
            onoffscript.chestspot += change;
        }
        if (feet == true)
        {
            onoffscript.feetspot += change;
        }
    }
}
