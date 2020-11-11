using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [Header("Lists of Items")]
    [SerializeField] List<DollyCartControl> dollyCartControls;
    [SerializeField] List<CinemachineVirtualCamera> cameras;
    [SerializeField] List<int> enemiesToKill;
    [SerializeField] List<GameObject> enemies;


    [Header("Internal Varibles for Testing")]
    [SerializeField] int enemiesKilled;
    bool endLoaded = false;
    int yellowScore;
    int blueScore;
    int greenScore;
    int redScore;

    [SerializeField] float enemyMoveSpeed;

    private int activeSection = 0;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
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

    public void SetActiveSection(int SectionID)
    {
        cameras[activeSection].m_Priority = 1;
        activeSection = SectionID;
        cameras[SectionID].m_Priority = 1000;
        enemies[SectionID].SetActive(true);
    }

    public CinemachineVirtualCamera GetActiveCamera()
    {
        return cameras[activeSection];
    }

    public float GetEnemyMoveSpeed()
    {
        return enemyMoveSpeed;
    }

    public void SetEnemyKilled(int amountOfEnemiesKilled)
    {
        enemiesKilled += amountOfEnemiesKilled;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeSection != 5) { dollyCartControls[activeSection].startCart.Invoke(); 


        if (enemiesKilled >= enemiesToKill[activeSection])
        {
            SetActiveSection(activeSection + 1);
        }
        }
        if (enemiesKilled>= enemiesToKill[enemiesToKill.Count - 1])
        {
            if (endLoaded == false)
            {
                this.GetComponent<SceneLoader>().LoadScene(2);
                endLoaded = true;
            }
        }
    }
}
