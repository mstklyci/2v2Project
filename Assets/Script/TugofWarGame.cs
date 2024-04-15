using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TugofWarGame : MonoBehaviour
{

    [SerializeField] private Slider tugofWar;
    [SerializeField] private Button player1Button, player2Button;
    [SerializeField] private GameObject player1Win, player2Win;


    void Start()
    {
        tugofWar = GameObject.Find("Slider").GetComponent<Slider>();
        player1Button = GameObject.Find("Player1Button").GetComponent<Button>();
        player2Button = GameObject.Find("Player2Button").GetComponent<Button>();
        player1Win = GameObject.Find("Player1Win");
        player2Win = GameObject.Find("Player2Win");

        player1Win.SetActive(false);
        player2Win.SetActive(false);

        if (player1Button != null)
        {
            player1Button.onClick.AddListener(Player1Button);
        }
        if(player2Button != null)
        {
            player2Button.onClick.AddListener(Player2Button);
        }

    }

    void Player1Button()
    {
        tugofWar.value += 5;
    }
    void Player2Button()
    {
        tugofWar.value -= 5;
    }

    private void Update()
    {
        if (tugofWar.value <= 0)
        {
            player2Win.SetActive(true);
        }
        else if (tugofWar.value >= 100)
        {
            player1Win.SetActive(true);
        }
    }
}