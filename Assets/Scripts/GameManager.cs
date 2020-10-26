using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] DollyCartControl[] dollyCartControls;
    [SerializeField] CinemachineVirtualCamera[] cameras;
    [SerializeField] int[] enemiesToKill;
    public int enemiesKilled;

    private int activeSection = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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
