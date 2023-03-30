using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetpalyerName : MonoBehaviour
{
    public GameObject PlayerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    async public void OnSendContract()
    {
        string TheInput = PlayerName.GetComponent<Text>().text;
        // smart contract method to call
        string method = "createName";
        // abi in json format
        string abi = "[ { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"name\": \"addressToName\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"string\", \"name\": \"_name\", \"type\": \"string\" } ], \"name\": \"createName\", \"outputs\": [], \"stateMutability\": \"payable\", \"type\": \"function\" } ]";
        // address of contract
        string contract = "0x5D074fA475134501518bFa8eeb48131760a9ee55";
        // array of arguments for contract
        string args = "[\"" + TheInput + "\"]";
        // value in wei
        string value = "0";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        
        string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
        Debug.Log(response);

    }
}
