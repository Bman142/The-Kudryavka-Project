using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameOverManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI redScore;
    [SerializeField] TextMeshProUGUI blueScore;
    [SerializeField] TextMeshProUGUI greenScore;
    [SerializeField] TextMeshProUGUI yellowScore;
    [SerializeField] TextMeshProUGUI winnerText;

    private SAE.ArcadeMachine.PlayerColorId winner;


    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        redScore.text = "RED: " + gameManager.GetScore(SAE.ArcadeMachine.PlayerColorId.RED_PLAYER).ToString();
        blueScore.text = "BLUE: " + gameManager.GetScore(SAE.ArcadeMachine.PlayerColorId.BLUE_PLAYER).ToString();
        yellowScore.text = "YELLOW: " + gameManager.GetScore(SAE.ArcadeMachine.PlayerColorId.YELLOW_PLAYER).ToString();
        greenScore.text = "GREEN: " + gameManager.GetScore(SAE.ArcadeMachine.PlayerColorId.GREEN_PLAYER).ToString();

        winner = GetHighScore();
        switch (winner)
        {
            case SAE.ArcadeMachine.PlayerColorId.BLUE_PLAYER:
                winnerText.text = "Blue got the Highest score at " + gameManager.GetScore(SAE.ArcadeMachine.PlayerColorId.BLUE_PLAYER).ToString() + " points";
                break;
            case SAE.ArcadeMachine.PlayerColorId.GREEN_PLAYER:
                winnerText.text = "Green got the Highest score at " + gameManager.GetScore(SAE.ArcadeMachine.PlayerColorId.GREEN_PLAYER).ToString() + " points";
                break;
            case SAE.ArcadeMachine.PlayerColorId.RED_PLAYER:
                winnerText.text = "Red got the Highest score at " + gameManager.GetScore(SAE.ArcadeMachine.PlayerColorId.RED_PLAYER).ToString() + " points";
                break;
            case SAE.ArcadeMachine.PlayerColorId.YELLOW_PLAYER:
                winnerText.text = "Yellow got the Highest score at " + gameManager.GetScore(SAE.ArcadeMachine.PlayerColorId.YELLOW_PLAYER).ToString() + " points";
                break;

        }

    }

    private SAE.ArcadeMachine.PlayerColorId GetHighScore()
    {
        int highScore = 0;
        SAE.ArcadeMachine.PlayerColorId winner = SAE.ArcadeMachine.PlayerColorId.UNKNOWN;

        List<SAE.ArcadeMachine.PlayerColorId> playerColorIds = new List<SAE.ArcadeMachine.PlayerColorId>();
        playerColorIds.Add(SAE.ArcadeMachine.PlayerColorId.BLUE_PLAYER);
        playerColorIds.Add(SAE.ArcadeMachine.PlayerColorId.GREEN_PLAYER);
        playerColorIds.Add(SAE.ArcadeMachine.PlayerColorId.RED_PLAYER);
        playerColorIds.Add(SAE.ArcadeMachine.PlayerColorId.YELLOW_PLAYER);

        foreach (SAE.ArcadeMachine.PlayerColorId playerColorId in playerColorIds)
        {
            if (gameManager.GetScore(playerColorId) > highScore)
            {
                highScore = gameManager.GetScore(playerColorId);
                winner = playerColorId;
            }
        }
        return winner;
    }

}
