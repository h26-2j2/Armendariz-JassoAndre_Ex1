using UnityEngine;

public class MouvementMeteor : MonoBehaviour
{
    public float vitesseY;
    public float limiteHaut;
    public float limiteBas;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Logique de deplacement
        transform.position += new Vector3(0, vitesseY, 0) * Time.deltaTime;

        if (transform.position.y > limiteHaut)
        {
            transform.position = new Vector3(limiteBas, transform.position.y);
        }


    }
}
  