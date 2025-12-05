using UnityEngine;

public class MovimientoEsfera : MonoBehaviour
{
    [Header("Movemente Data")]
    public float gradosPorSegundo = 360f;

    [Header("Vamos a contar verdades")]
    [Range(0,10f)] public float enriqueGuapo;
    [Space(30)]
    public float alumnosListos;
    public Color colorDelSombreroDelEnrique;

    private void Start()
    {
        //transform.position = new Vector3(3f, 0f, 0f);
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, gradosPorSegundo * Time.deltaTime);
    }
}
