using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1 : MonoBehaviour
{
    public Vector3 m_CamDirection = new Vector3(0f, 1f, 0f);

    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(m_CamDirection * Time.deltaTime); 
    }
}
