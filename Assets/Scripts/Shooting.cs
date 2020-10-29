using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SAE;

public class Shooting : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        player = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Yellow Player SHooting COde
        if (ArcadeMachine.PlayerPressingButtonStatic(ArcadeMachine.PlayerColorId.YELLOW_PLAYER, 0, true) == true)
        {
            Ray ray = mainCam.ScreenPointToRay(player.position);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Enemy") 
                {
                    hitInfo.collider.gameObject.GetComponent<EnemyController>().takeDamage(1, ArcadeMachine.PlayerColorId.YELLOW_PLAYER);
                }
                
            }
        }

        if (ArcadeMachine.PlayerPressingButtonStatic(ArcadeMachine.PlayerColorId.YELLOW_PLAYER, 1, true) == true)
        { 

        }

        //Blue Player Shooting Code
        if (ArcadeMachine.PlayerPressingButtonStatic(ArcadeMachine.PlayerColorId.BLUE_PLAYER, 0, true) == true)
        {
            Ray ray = mainCam.ScreenPointToRay(player.position);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Enemy")
                {
                    hitInfo.collider.gameObject.GetComponent<EnemyController>().takeDamage(1, ArcadeMachine.PlayerColorId.BLUE_PLAYER);
                }

            }
        }
        //Red Player Shooting Code
        if (ArcadeMachine.PlayerPressingButtonStatic(ArcadeMachine.PlayerColorId.RED_PLAYER, 0, true) == true)
        {
            Ray ray = mainCam.ScreenPointToRay(player.position);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Enemy")
                {
                    hitInfo.collider.gameObject.GetComponent<EnemyController>().takeDamage(1, ArcadeMachine.PlayerColorId.RED_PLAYER);
                }

            }
        }

        //Green Player Shooting Code
        if (ArcadeMachine.PlayerPressingButtonStatic(ArcadeMachine.PlayerColorId.GREEN_PLAYER, 0, true) == true)
        {
            Ray ray = mainCam.ScreenPointToRay(player.position);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Enemy")
                {
                    hitInfo.collider.gameObject.GetComponent<EnemyController>().takeDamage(1, ArcadeMachine.PlayerColorId.GREEN_PLAYER);
                }

            }
        }
    }
}
