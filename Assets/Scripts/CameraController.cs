using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float Speed;
    public float ZoomSpeed;
    public float MinZoomValue;
    public float MaxZoomValue;

    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        Move();
        Zoom();
    }

    private void Move()
    {
        var xValue = Input.GetAxis("Horizontal");
        var yValue = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector2(xValue, yValue);
        transform.position += move * (Speed * Time.deltaTime);
    }

    private void Zoom()
    {
        var scrollValue = Input.GetAxis("Mouse ScrollWheel");

        cam.orthographicSize += scrollValue * ZoomSpeed;
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, MinZoomValue, MaxZoomValue);
    }
}