using UnityEngine;
using TMPro;

public class ContadorDePuntos : MonoBehaviour
{
    TextMeshProUGUI texto;

    void Awake()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }
    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        texto.text = "Puntos: " + EsferaDestruible.puntuacionTotal;
    }

    private void LateUpdate()
    {
        
    }
}
