using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeup : MonoBehaviour
{
    public Animator curtains;
    static public List <GameObject> backgrounds = new List<GameObject>();
    public string boolname;
    private int selectedbg;
    public GameObject curtains_;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(delay());
       

    }
    // Update is called once per frame
    void Update()
    {
       if (TimerScript.TimerOn == false)
        {
            curtains.SetBool(boolname, true);
           StartCoroutine(dropdown());
            curtains_.SetActive(true);

        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        Debug.Log(backgrounds.Count);
        selectedbg = Random.Range(0, backgrounds.Count); 
    
    }
    IEnumerator dropdown()
    {
        yield return new WaitForSeconds(2f);
        backgrounds[selectedbg].SetActive(true);
    }

}
//