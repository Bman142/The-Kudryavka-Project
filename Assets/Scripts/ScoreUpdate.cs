using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SAE;

public class ScoreUpdate : MonoBehaviour
{
    [SerializeField] ArcadeMachine.PlayerColorId player;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameManager manager;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        text = this.GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = manager.GetScore(player).ToString();
    }
}
