using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "avalanche";
        string network = "mainnet";
        string contract = "0xa695ea0C90D89a1463A53Fa7a02168Bc46FbBF7e";
        string account = "0x47d3a62a293b5521a161b0dd6a825c0218224d4e";
        string tokenId = "130";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        print(balanceOf);
        print("test: " + balanceOf);
    }
}
