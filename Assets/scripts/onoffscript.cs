using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffscript : MonoBehaviour
{
    static public List<GameObject> headtotal = new List<GameObject>();
    static public List<GameObject> chesttotal = new List<GameObject>();
    static public List<GameObject> feettotal = new List<GameObject>();
    static public List<GameObject> headlist = new List<GameObject>();
    static public List<GameObject> chestlist = new List<GameObject>();
    static public List<GameObject> feetlist = new List<GameObject>();
    static public int headspot = 0;
    static public int chestspot = 0;
    static public int feetspot = 0;
    private GameObject ignoreditem;
    public int numberofclothes = 3;
    private GameObject selected;
    private List<GameObject>[] totallistarray = new List<GameObject>[] { headtotal, chesttotal, feettotal };
    private List<GameObject>[] listarray = new List<GameObject>[] { headlist, chestlist, feetlist };
    //private int[] spots = new int[] { headspot, chestspot, feetspot };
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(addlists());
    }
    IEnumerator addlists()
    {
        yield return new WaitForSeconds(0.1f);

        foreach (GameObject item in headtotal)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in chesttotal)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in feettotal)
        {
            item.SetActive(false);
        }
        for (int i = 0; i < numberofclothes; i++)
        {
            int ranunm = Random.Range(0, headtotal.Count);
            selected = headtotal[ranunm];
            Debug.Log(headtotal.Count);
            if (headlist.Contains(selected) == false)
            {
                headlist.Add(selected);
            }
            else
            {
                i--;
            }

        }

        for (int i = 0; i < numberofclothes; i++)
        {
            int ranunm = Random.Range(0, chesttotal.Count);
            selected = chesttotal[ranunm];
            if (chestlist.Contains(selected) == false)
            {
                chestlist.Add(selected);
            }
            else
            {
                i--;
            }

        }

        for (int i = 0; i < numberofclothes; i++)
        {
            int ranunm = Random.Range(0, feettotal.Count);
            selected = feettotal[ranunm];
            if (feetlist.Contains(selected) == false)
            {
                feetlist.Add(selected);
            }
            else
            {
                i--;
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        int[] spots = new int[] { headspot, chestspot, feetspot };
        for (int i = 0; i < listarray.Length; i++)
        {
 
            Debug.Log(headspot);
            Debug.Log(spots[0]);

            if (listarray[i].Count - 1 < spots[i])
            {
                spots[i] = 0;
            }
            if (0 > spots[i])
            {
                spots[i] = listarray[i].Count - 1;
            }

            ignoreditem = listarray[i][spots[i]];

            listarray[i][spots[i]].SetActive(true);
            foreach (GameObject item in listarray[i])
            {
                if (item == ignoreditem) continue;
                item.SetActive(false);

            }
        }
        headspot = spots[0];
        chestspot = spots[1];
        feetspot = spots[2];
        
    }
}
