﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SAE;
using UnityEngine.SceneManagement;

public class CursorContoller : MonoBehaviour
{
    [SerializeField] Transform yellowPlayer;
    [SerializeField] Transform bluePlayer;
    [SerializeField] Transform redPlayer;
    [SerializeField] Transform greenPlayer;

    public int moveSpeed;

    [SerializeField] Vector2 wrapSize;
    private PlayerCountManager countManager;
    private int playerCount;

    [SerializeField] TextMeshProUGUI yellowScore;
    [SerializeField] TextMeshProUGUI blueScore;
    [SerializeField] TextMeshProUGUI redScore;
    [SerializeField] TextMeshProUGUI greenScore;
    // Start is called before the first frame update


    void Awake()
    {
        countManager = GameObject.Find("PlayerCountManager").GetComponent<PlayerCountManager>();
        SetPlayerNumbers();
        
        
    }

    void SetPlayerNumbers()
    {
        playerCount = countManager.GetPlayerCount();
        switch (playerCount)
        {
            case 1:
                yellowPlayer.gameObject.SetActive(true);
                yellowScore.gameObject.SetActive(true);
                break;
            case 2:
                yellowPlayer.gameObject.SetActive(true);
                yellowScore.gameObject.SetActive(true);
                bluePlayer.gameObject.SetActive(true);
                blueScore.gameObject.SetActive(true);
                break;
            case 3:
                yellowPlayer.gameObject.SetActive(true);
                yellowScore.gameObject.SetActive(true);
                bluePlayer.gameObject.SetActive(true);
                blueScore.gameObject.SetActive(true);
                redPlayer.gameObject.SetActive(true);
                redScore.gameObject.SetActive(true);
                break;
            case 4:
                yellowPlayer.gameObject.SetActive(true);
                yellowScore.gameObject.SetActive(true);
                bluePlayer.gameObject.SetActive(true);
                blueScore.gameObject.SetActive(true);
                redPlayer.gameObject.SetActive(true);
                redScore.gameObject.SetActive(true);
                greenPlayer.gameObject.SetActive(true);
                greenScore.gameObject.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 axisValues = ArcadeMachine.PlayerJoystickAxisStatic(ArcadeMachine.PlayerColorId.YELLOW_PLAYER);
        this.yellowPlayer.position += new Vector3(axisValues.x, -axisValues.y, 0f) * this.moveSpeed;

        axisValues = ArcadeMachine.PlayerJoystickAxisStatic(ArcadeMachine.PlayerColorId.BLUE_PLAYER);
        this.bluePlayer.position += new Vector3(axisValues.x, -axisValues.y, 0f) * this.moveSpeed;

        axisValues = ArcadeMachine.PlayerJoystickAxisStatic(ArcadeMachine.PlayerColorId.RED_PLAYER);
        this.redPlayer.position += new Vector3(axisValues.x, -axisValues.y, 0f) * this.moveSpeed;

        axisValues = ArcadeMachine.PlayerJoystickAxisStatic(ArcadeMachine.PlayerColorId.GREEN_PLAYER);
        this.greenPlayer.position += new Vector3(axisValues.x, -axisValues.y, 0f) * this.moveSpeed;


        

        //Check For Offscreen
        
    }
}
