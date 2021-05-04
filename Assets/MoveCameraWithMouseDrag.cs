using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MoveCameraWithMouseDrag : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    // Start is called before the first frame update
    void Start()
    {
        CinemachineFreeLook cm = cam.GetComponent<CinemachineFreeLook>();
        //cm.m_XAxis.va
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
