using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve : MonoBehaviour
{
    [SerializeField] AnimationCurve curva;
    [SerializeField] float duracion = 5f;
    Light luz;
    float t = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        luz=GetComponent<Light>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        luz.intensity = 10 * curva.Evaluate(t /duracion);
        t += Time.deltaTime;
    }
}
