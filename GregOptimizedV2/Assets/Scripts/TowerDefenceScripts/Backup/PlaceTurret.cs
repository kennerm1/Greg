/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlaceTurret : MonoBehaviour
{
    public XRRayInteractor rayInteractor;
    public GameObject turretPrefab;
    //public Camera mainCamera;
    public InputHelpers.Button placementButton = InputHelpers.Button.Trigger;
    public float buttonThreshold = 0.1f;
    public XRController controller;

    private bool GetInput()
    {
        if (controller != null)
        {
            controller.inputDevice.IsPressed(placementButton, out bool isPressed, buttonThreshold);
            if (isPressed )
            {
                Debug.Log("Button pressed");
            }
            return isPressed;
        }
        else
        {
            return false;
        }

    }

    void Start()
    {
        if (controller == null )
        {
            controller = GetComponent<XRController>();
        }
    }

    void Update()
    {
        
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 position = hit.point;
                //Instantiate(turret, position, Quaternion.identity);
                //GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
                //turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);

            }
        }*/

        /*if (rayInteractor != null && rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            //Debug.Log("Getting button information");
            if (GetInput())
            {
                Debug.Log("Turret placed");
                Instantiate(turretPrefab, hit.point, Quaternion.identity);
            }
        }
    }
}*/
