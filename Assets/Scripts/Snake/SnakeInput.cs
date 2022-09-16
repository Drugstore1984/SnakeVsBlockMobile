using Cinemachine;
using UnityEngine;
using UnityEngine.EventSystems;

public class SnakeInput : MonoBehaviour
{
    private Camera mainCamera;
    private CinemachineVirtualCamera cmCamera;
    private Vector3 direction;
    [SerializeField] LayerMask _layermask;

    private void Start()
    {
        mainCamera = Camera.main;
        cmCamera = FindObjectOfType<CinemachineVirtualCamera>();
        cmCamera.Follow = transform;
    }
    public Vector3 Direction()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, float.MaxValue))
            {
                return direction = (hitInfo.point - transform.position);
            }
        }
        else
        {
            return direction = Vector3.zero;
        }
        return direction = Vector3.zero;
    }
}
