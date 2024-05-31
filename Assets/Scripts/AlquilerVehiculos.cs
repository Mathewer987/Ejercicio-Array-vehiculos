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
            DesactivarVehiculos();

            int t = Random.Range(0, vehiculos.Length);

            vehiculos[t].SetActive(true);
        }   
    }

    void ResetearVehiculos()
    {
        

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
