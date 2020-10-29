using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SAE;

public class CursorContoller : MonoBehaviour
{
    [SerializeField] Transform yellowPlayer;
    [SerializeField] Transform bluePlayer;
    [SerializeField] Transform redPlayer;
    [SerializeField] Transform greenPlayer;

    public int moveSpeed;

    [SerializeField] Vector2 wrapSize;
    // Start is called before the first frame update
    void Start()
    {
        
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


        if (ArcadeMachine.PlayerPressingButtonStatic(ArcadeMachine.PlayerColorId.YELLOW_PLAYER, 0, true) == true)
        { moveSpeed += 1; }

        if (ArcadeMachine.PlayerPressingButtonStatic(ArcadeMachine.PlayerColorId.YELLOW_PLAYER, 1, true) == true)
        { moveSpeed -= 1; }

        //Check For Offscreen

    }
}
