using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScreen : MonoBehaviour
{

    public float valorEmpuje;
    private Camera camaraPrincipal;

    private void Start()
    {
        camaraPrincipal = Camera.main;
    }

    private void Update()
    {

        Vector3 posicionViewport = camaraPrincipal.WorldToViewportPoint(transform.position);

        if (posicionViewport.x > 1)
        {
            transform.position = camaraPrincipal.ViewportToWorldPoint(new Vector3(valorEmpuje, posicionViewport.y, posicionViewport.z));
        }
        else if (posicionViewport.x < 0)
        {
            transform.position = camaraPrincipal.ViewportToWorldPoint(new Vector3(1- valorEmpuje, posicionViewport.y, posicionViewport.z));
        }


        if (posicionViewport.y > 1)
        {
            transform.position = camaraPrincipal.ViewportToWorldPoint(new Vector3(posicionViewport.x, valorEmpuje, posicionViewport.z));
        }
        else if (posicionViewport.y < 0)
        {
            transform.position = camaraPrincipal.ViewportToWorldPoint(new Vector3(posicionViewport.x, 1-valorEmpuje, posicionViewport.z));
        }


    }
}
