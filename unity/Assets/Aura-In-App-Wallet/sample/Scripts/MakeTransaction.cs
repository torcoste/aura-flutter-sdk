using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Numerics;

public class MakeTransaction : MonoBehaviour
{
    [SerializeField]
    TMP_Text info;
    [SerializeField]
    TMP_InputField toAddress, amount;
    [SerializeField]
    Button send;
    // Start is called before the first frame update
    async void Start()
    {
        BigInteger balance = await DemoIAW.wallet.GetBalance();
        info.text = "From address: " + DemoIAW.wallet.address + "\n" + "Balance: " + balance.ToString();
        send.onClick.AddListener(async () => {
            var tx = await DemoIAW.wallet.CreateTransaction(toAddress.text, amount.text);
            await DemoIAW.wallet.SignTransaction(tx);
            await AuraMobileSDK.AuraWallet.BroadcastTx(tx);
            
            //go back to main menu
            DemoIAW.instance.currentScreen = DemoIAW.Screen.MAIN_MENU;
        });
    }
}
