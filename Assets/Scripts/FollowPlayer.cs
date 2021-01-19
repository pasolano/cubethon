using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update() {
        // this object's (camera) transform
        transform.position = player.position + offset;
    }
}
