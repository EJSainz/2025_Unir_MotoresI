using UnityEngine;

public class EsferaDestruible : MonoBehaviour
{
    public static int puntuacionTotal = 0;

    [SerializeField] float startSpeed = 1f;

    Vector3 velocity = Vector3.zero;
    Vector3 gravity = Vector3.down * 0.98f;

    [SerializeField] GameObject efectoAlMorirPrefab;


    private void Awake()
    {
        
    }


    private void Start()
    {
        velocity = Random.onUnitSphere * startSpeed;
    }

    private void Update()
    {
        velocity += gravity * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }

    public void NotifyHasBeenHit()
    {
        Debug.Log("M'han dao");
        puntuacionTotal += 10;
        PerformDestruction();
    }

    private void PerformDestruction()
    {
        Destroy(gameObject);
        Instantiate(efectoAlMorirPrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LimiteInferior"))
            { PerformDestruction(); }
    }

    private void OnDestroy()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown", this);
    }

    private void OnMouseOver()
    {
        Debug.Log("OnMouseOver", this);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, velocity.normalized * 10f);
    }

    private void OnDrawGizmosSelected()
    {
        
    }
}
