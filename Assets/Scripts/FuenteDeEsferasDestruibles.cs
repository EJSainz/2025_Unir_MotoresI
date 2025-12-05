using UnityEngine;

public class FuenteDeEsferasDestruibles : MonoBehaviour
{
    [SerializeField] GameObject esferaDestruiblePrefab;
    [SerializeField] float tiempoEntreCreacionDeEsferas = 1f;

    float tiempoTranscurrido = 0f;

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;
        if (tiempoTranscurrido > tiempoEntreCreacionDeEsferas)
        {
            tiempoTranscurrido = 0f;
            Instantiate(esferaDestruiblePrefab, transform.position, Quaternion.identity);
        }
    }
}
