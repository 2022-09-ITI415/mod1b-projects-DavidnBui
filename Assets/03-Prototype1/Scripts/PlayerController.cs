using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public Text countText;
    public Text winText;

    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    int m_Count;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Count = 0;
        winText.text = "";
    }

    void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        m_Movement.Set(horizontal, 0f, vertical);

        m_Rigidbody.AddForce(m_Movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            m_Count++;
        }
    }

}