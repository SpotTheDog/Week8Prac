using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private int coin1;
    private int coin2;
    public Player coinInfo;
    public Player coinInfo2;
    public Text player1Score;
    public Text player2Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coin1 = coinInfo.coinRead1;
        coin2 = coinInfo2.coinRead2;
        player1Score.text = "Player 1 Score: " + coin1;
        player2Score.text = "Player 2 Score: " + coin2;
    }
}
