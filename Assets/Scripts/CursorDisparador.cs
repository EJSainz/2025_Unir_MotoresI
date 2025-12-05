using UnityEngine;
using UnityEngine.InputSystem;

public class CursorDisparador : MonoBehaviour
{
    [SerializeField] Camera laCamaraQueQuieroUtilizar;

    Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    RaycastHit hit;
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            //Debug.Log(Mouse.current.position.ReadValue());
            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.royalBlue);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log($"He encontrado a lo largo del rayo el objeto {hit.collider.name}");
                //Destroy(hit.collider.gameObject);
                EsferaDestruible esferaDestruible = hit.collider.GetComponent<EsferaDestruible>();
                esferaDestruible.NotifyHasBeenHit();
            }
        }
    }
}
