using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAccount : MonoBehaviour
{
    public Text AccountDisplay;
    // Start is called before the first frame update
    void Start()
    {
        string account = PlayerPrefs.GetString("Account");
        AccountDisplay.text = account;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
