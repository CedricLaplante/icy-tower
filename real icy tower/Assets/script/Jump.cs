using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Vector3 m_Jump = new Vector3();
    public float m_Jumpspeed = 100f;
    private bool CanJump; 
    public Rigidbody m_Rigidbody;
    // JUMP
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>(); 
    }

    
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CanJump)
            {
                m_Rigidbody.AddForce(0f, m_Jumpspeed, 0f);
                CanJump = false; 
            }
        }

    }





}
