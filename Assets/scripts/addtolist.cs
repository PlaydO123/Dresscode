using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addtolist : MonoBehaviour
{
    public bool head;
    public bool chest;
    public bool feet;
    public bool bg;
    // Start is called before the first frame update
    void Start()
    {
        if (head == true)
        {
            onoffscript.headtotal.Add(this.gameObject);
        }
        if (chest == true)
        {
            onoffscript. chesttotal.Add(this.gameObject);
        }
        if (feet == true)
        {
            onoffscript.feettotal.Add(this.gameObject);
        }
        if (bg == true)
        {
            timeup.backgrounds.Add(this.gameObject);
        }
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
