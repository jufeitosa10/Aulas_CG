using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHook : MonoBehaviour
{
    GameObject m_Hooked;
    Vector3 m_prevPosition;

    void OnTriggerEnter(Collider other) {
        m_Hooked = other.gameObject;
    }

    void OnTriggerExit(Collider other) {
        m_Hooked = null;
    }

    private void Update() {
        if (m_Hooked != null) {
                       m_Hooked.SendMessage("OnPlatformMove", transform.position);
        }

        m_prevPosition = transform.position;
    }

}