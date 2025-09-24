using UnityEngine;

public class PlayerHookable : MonoBehaviour
{
    void OnPlatformMove(Vector3 by)
    {
        transform.position = by;
    }

}
