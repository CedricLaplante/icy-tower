using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement1 : MonoBehaviour
{   // Vector3 pour le mouvement
    Vector3 m_Mouvement = new Vector3();
    public Rigidbody m_Rigidbody;
     
    
    void Start()
    {
      
    }

    // deplacement du player 
    void Update()
    {
        m_Mouvement = m_Rigidbody.velocity;

        if (Input.GetKey(KeyCode.A))
        {
            m_Mouvement.z = -5f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            m_Mouvement.z = 5f;
        }
        else
        {
            m_Mouvement.z = 0f;
        }

    }
    private void FixedUpdate()
    {
        m_Rigidbody.velocity = m_Mouvement; 
    }
        
}
