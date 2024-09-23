using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCar : MonoBehaviour
{
    public GameObject atticusCar;
    public GameObject drewCar;
    public GameObject carloCar;
    public bool inputPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && !inputPressed)
        {
            if (carloCar.activeSelf)
            {
                inputPressed = true;
                drewCar.SetActive(true);
                carloCar.SetActive(false);
            }
            else if (drewCar.activeSelf)
            {
                inputPressed = true;
                atticusCar.SetActive(true);
                drewCar.SetActive(false);
            }
            else if (atticusCar.activeSelf)
            {
                inputPressed = true;
                carloCar.SetActive(true);
                atticusCar.SetActive(false);
            }
            
        }

        inputPressed = false;


}
}
