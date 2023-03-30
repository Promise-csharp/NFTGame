using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetNameOfPlayer : MonoBehaviour
{
    public Text GetUserName;
    // Start is called before the first frame update
    async void Start()
    {
        // set chain: ethereum, moonbeam, polygon etc
        string chain = "ethereum";
        // set network mainnet, testnet
        string network = "goerli";
        // smart contract method to call
        string method = "addressToName";
        // abi in json format
        string abi = "[ { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"name\": \"addressToName\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"string\", \"name\": \"_name\", \"type\": \"string\" } ], \"name\": \"createName\", \"outputs\": [], \"stateMutability\": \"payable\", \"type\": \"function\" } ]";
        // address of contract
        string contract = "0x5D074fA475134501518bFa8eeb48131760a9ee55";
        //Acount 
        string v = PlayerPrefs.GetString("Account");
        // array of arguments for contract
        string args = "[\"" + v + "\"]";
        // connects to user's browser wallet to call a transaction
        string response = await EVM.Call(chain, network, contract, abi, method, args);
        // display response in game
        print(response);
        GetUserName.text= response;
        
    }

    async void FixedUpdate()
    {
        // set chain: ethereum, moonbeam, polygon etc
        string chain = "ethereum";
        // set network mainnet, testnet
        string network = "goerli";
        // smart contract method to call
        string method = "addressToName";
        // abi in json format
        string abi = "[ { \"inputs\": [ { \"internalType\": \"address\", \"name\": \"\", \"type\": \"address\" } ], \"name\": \"addressToName\", \"outputs\": [ { \"internalType\": \"string\", \"name\": \"\", \"type\": \"string\" } ], \"stateMutability\": \"view\", \"type\": \"function\" }, { \"inputs\": [ { \"internalType\": \"string\", \"name\": \"_name\", \"type\": \"string\" } ], \"name\": \"createName\", \"outputs\": [], \"stateMutability\": \"payable\", \"type\": \"function\" } ]";
        // address of contract
        string contract = "0x5D074fA475134501518bFa8eeb48131760a9ee55";
        //Acount 
        string v = PlayerPrefs.GetString("Account");
        // array of arguments for contract
        string args = "[\"" + v + "\"]";
        //rpc

        // connects to user's browser wallet to call a transaction
        string response = await EVM.Call(chain, network, contract, abi, method, args);
        // display response in game
        print(response);
        GetUserName.text = response; 
    }

   
}
