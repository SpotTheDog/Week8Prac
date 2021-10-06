using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int player1Coins;
    private int player2Coins;
    public int coinRead1
    {
        get
        {
            return player1Coins;
        }
    }
    public int coinRead2
    {
        get
        {
            return player2Coins;
        }
    }
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vx = Input.GetAxis("Horizontal");
        float vy = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(vx, vy, 0) * speed;
        transform.Translate(velocity * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            if(gameObject.tag == "Player1")
            {
                player1Coins++;
            }
            if(gameObject.tag == "Player2")
            {
                player2Coins++;
            }
        }
    }
}
