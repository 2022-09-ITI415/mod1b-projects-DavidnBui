using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public TextMeshProUGUI countText;
    public Text winText;

    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    private int m_Count;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Count = 0;

        SetCountText();
        winText.text = "";
    }

    void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        m_Movement.Set(horizontal, 0f, vertical);

        m_Rigidbody.AddForce(m_Movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            m_Count = m_Count + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + m_Count.ToString();
        if(m_Count >= 11)
        {
            winText.text= "You Win!";
        }
    }

}