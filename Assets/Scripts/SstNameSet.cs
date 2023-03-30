using Org.BouncyCastle.Asn1.Esf;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SstNameSet : MonoBehaviour
{
    public GameObject[] ObjectToBeActive;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject Obj in ObjectToBeActive)
        {
            Obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            foreach(GameObject Obj in ObjectToBeActive) 
            { 
                Obj.SetActive(true);
            }
        }
    }
    public void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            foreach (GameObject Obj in ObjectToBeActive)
            {
                Obj.SetActive(false);
            }
        }
    }
}
