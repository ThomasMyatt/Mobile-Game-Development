using UnityEngine;

public class Cam_Follow : MonoBehaviour
{
    public Transform playerFollow;

    public float offset = 0f;
    public float smoothDamp = 0.2f;
    float velocity;
    

    // Update is called once per frame
    void LateUpdate()
    {
       Vector3 pos = transform.position;
        float playerHeight = Mathf.Max(pos.y, playerFollow.position.y + offset);
        pos.y = Mathf.SmoothDamp(pos.y, playerHeight, ref velocity, smoothDamp);
        transform.position = pos;
    }
}
