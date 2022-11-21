using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayAddress : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        string account = PlayerPrefs.GetString("Account");
        print(account);
        text.text = account;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
