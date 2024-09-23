using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCar : MonoBehaviour
{
    public GameObject atticusCar;
    public GameObject drewCar;
    public GameObject carloCar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            if (carloCar.activeSelf)
            {
                drewCar.SetActive(true);
                carloCar.SetActive(false);
            }
            else if (drewCar.activeSelf)
            {
                atticusCar.SetActive(true);
                drewCar.SetActive(false);
            }
            else if (atticusCar.activeSelf)
            {
                carloCar.SetActive(true);
                atticusCar.SetActive(false);
            }
        }
    }
}
