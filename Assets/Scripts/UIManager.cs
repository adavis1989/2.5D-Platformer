using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _Coinsdisplayed;
    private int _coins;
    // Start is called before the first frame update
    void Start()
    {
        _Coinsdisplayed.text = "Coins: " + _coins;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CoinsCollected(int Collected)
    {
        _coins += Collected;
        _Coinsdisplayed.text = "Coins: " + _coins;

    }
}
