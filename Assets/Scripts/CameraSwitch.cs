using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour

{

    public GameObject arCamera;
    public GameObject dtCamera;
    public bool armode;
    public GameObject digitalTwinModel;
        
    // Start is called before the first frame update
    void Start()
    {
        armode = true;
        cameraswitcher();
    }

    // Update is called once per frame
    public void cameraswitcher()
    {
        if (armode == true)
        {
            digitalTwinModel.SetActive(false);
            arCamera.SetActive(true);
            dtCamera.SetActive(false);
            armode = false;
        }
        else
        {
            digitalTwinModel.SetActive(true);

            arCamera.SetActive(false);
            dtCamera.SetActive(true);
            armode = true;
        }
    }
}
