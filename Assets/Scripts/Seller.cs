using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Seller : MonoBehaviour
{
    public CinemachineVirtualCamera VCamDisable;
    public CinemachineVirtualCamera VCamEnable;
    public GameObject UI;
    private PlayerController _playerMover;
    private bool _canbuy = true;
    private float time = 1f;
    
    private void OnTriggerEnter(Collider other) 
    {
        if(_canbuy)
        {
            VCamDisable.gameObject.SetActive(false);
            VCamEnable.gameObject.SetActive(true);
            Camera.main.cullingMask &= ~(1 << 8);
            _playerMover = other.GetComponent<PlayerController>();
            _playerMover.canMove = false;
            UI.SetActive(true);
            _canbuy = false;

        }


    }
}
