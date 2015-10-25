using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public Transform FollowTarget;
    public float DampTime = 0.15f;
    private Vector3 Velocity = Vector3.zero;

    private Camera _camera;

    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = _camera.WorldToViewportPoint(FollowTarget.position);
        Vector3 delta = FollowTarget.position - _camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
        Vector3 destination = transform.position + delta;

        var pos = Vector3.SmoothDamp(transform.position, destination, ref Velocity, DampTime);
        //pos.x = Mathf.Clamp(pos.x, LeftBounds, RightBounds);
        //pos.y = Mathf.Clamp(pos.y, BottomBounds, TopBounds);

        transform.position = pos;
    }

    void FixedUpdate()
    {

    }
}
