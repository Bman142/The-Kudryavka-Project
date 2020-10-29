using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<DollyCartControl> dollyCartControls;
    [SerializeField] List<CinemachineVirtualCamera> cameras;
    [SerializeField] List<int> enemiesToKill;
    public int enemiesKilled;

    int yellowScore;
    int blueScore;
    int greenScore;
    int redScore;

    private int activeSection = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void UpdateScore(int score, SAE.ArcadeMachine.PlayerColorId player)
    {
        switch (player)
        {
            case SAE.ArcadeMachine.PlayerColorId.BLUE_PLAYER:
                blueScore =+ score;
                break;
            case SAE.ArcadeMachine.PlayerColorId.GREEN_PLAYER:
                greenScore = +score;
                break; ;
            case SAE.ArcadeMachine.PlayerColorId.RED_PLAYER:
                redScore = +score;
                break; ;
            case SAE.ArcadeMachine.PlayerColorId.YELLOW_PLAYER:
                yellowScore = +score;
                break; ;
        }
    }

    public int GetScore(SAE.ArcadeMachine.PlayerColorId player)
    {
        switch (player)
        {
            case SAE.ArcadeMachine.PlayerColorId.BLUE_PLAYER:
                return blueScore;
            case SAE.ArcadeMachine.PlayerColorId.GREEN_PLAYER:
                return greenScore;
            case SAE.ArcadeMachine.PlayerColorId.RED_PLAYER:
                return redScore;
            case SAE.ArcadeMachine.PlayerColorId.YELLOW_PLAYER:
                return yellowScore;
        }
        return 0;
    }
    public void setActiveCamera(int cameraID)
    {
        cameras[activeSection].m_Priority = 1;
        activeSection = cameraID;
        cameras[cameraID].m_Priority = 1000;
    }


    // Update is called once per frame
    void Update()
    {
        dollyCartControls[activeSection].startCart.Invoke();

        if (enemiesKilled >= enemiesToKill[activeSection])
        {
            setActiveCamera(activeSection + 1);
        }
    }
}
