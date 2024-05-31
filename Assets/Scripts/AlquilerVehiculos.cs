using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

        }   
    }

    void ResetearVehiculos()
    {
        DesactivarVehiculos();
        vehiculos[0].SetActive(true);

    }

    void DesactivarVehiculos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            if (!(i >= vehiculos.Length)) { 
            vehiculos[i].SetActive(false);
            }
        }
    }
}
