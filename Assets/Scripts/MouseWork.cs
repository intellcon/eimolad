using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
// using UnityEngine.UIElements;
using UnityEngine.UI;

public class MouseWork : MonoBehaviour
{

    public float mouseSpeed = 4.0f;

    public Slider mouseSens;
    public Slider scrollSens;

    public Toggle invertX;
    public Toggle invertY;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (invertX.isOn) { GetComponent<CinemachineFreeLook>().m_XAxis.Value = GetComponent<CinemachineFreeLook>().m_XAxis.Value + Input.GetAxis("Mouse X") * mouseSens.value; }
            else { GetComponent<CinemachineFreeLook>().m_XAxis.Value = GetComponent<CinemachineFreeLook>().m_XAxis.Value - Input.GetAxis("Mouse X") * mouseSens.value; }

            if (invertY.isOn) { GetComponent<CinemachineFreeLook>().m_YAxis.Value = GetComponent<CinemachineFreeLook>().m_YAxis.Value + Input.GetAxis("Mouse Y")/100 * mouseSens.value; }
            else { GetComponent<CinemachineFreeLook>().m_YAxis.Value = GetComponent<CinemachineFreeLook>().m_YAxis.Value - Input.GetAxis("Mouse Y")/100 * mouseSens.value; }
            
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
        {
            GetComponent<CinemachineFreeLook>().m_Orbits[0].m_Radius = GetComponent<CinemachineFreeLook>().m_Orbits[0].m_Radius + Input.GetAxis("Mouse ScrollWheel") * scrollSens.value;
            GetComponent<CinemachineFreeLook>().m_Orbits[1].m_Radius = GetComponent<CinemachineFreeLook>().m_Orbits[0].m_Radius + Input.GetAxis("Mouse ScrollWheel") * scrollSens.value;
            GetComponent<CinemachineFreeLook>().m_Orbits[2].m_Radius = GetComponent<CinemachineFreeLook>().m_Orbits[0].m_Radius + Input.GetAxis("Mouse ScrollWheel") * scrollSens.value;
            if (GetComponent<CinemachineFreeLook>().m_Orbits[0].m_Radius < 1) { GetComponent<CinemachineFreeLook>().m_Orbits[0].m_Radius = 1; }
            if (GetComponent<CinemachineFreeLook>().m_Orbits[1].m_Radius < 1) { GetComponent<CinemachineFreeLook>().m_Orbits[1].m_Radius = 1; }
            if (GetComponent<CinemachineFreeLook>().m_Orbits[2].m_Radius < 1) { GetComponent<CinemachineFreeLook>().m_Orbits[2].m_Radius = 1; }
            if (GetComponent<CinemachineFreeLook>().m_Orbits[0].m_Radius > 30) { GetComponent<CinemachineFreeLook>().m_Orbits[0].m_Radius = 30; }
            if (GetComponent<CinemachineFreeLook>().m_Orbits[1].m_Radius > 30) { GetComponent<CinemachineFreeLook>().m_Orbits[1].m_Radius = 30; } 
            if (GetComponent<CinemachineFreeLook>().m_Orbits[2].m_Radius > 30) { GetComponent<CinemachineFreeLook>().m_Orbits[2].m_Radius = 30; }
        }
        
    }

    private void FixedUpdate()
    {
    }
}
