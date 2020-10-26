using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class DollyCartControl : MonoBehaviour
{

    private CinemachineDollyCart Cart;

    public UnityEvent startCart;

    // Start is called before the first frame update
    void Start()
    {
        Cart = this.GetComponent<CinemachineDollyCart>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
