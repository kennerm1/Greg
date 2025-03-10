using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class PlaceTurrets : MonoBehaviour
{
    public XRRayInteractor rayInteractor;
    public GameObject turretPrefab;
    //private GameObject turret;
    public ActionBasedController controller;
    public InputActionReference placementAction;
    //public InputHelpers.Button placementButton = InputHelpers.Button.Trigger;
    //public float buttonThreshold = 0.1f;

    /*private bool GetInput()
    {
        if (controller != null)
        {
            controller.inputDevice.IsPressed(placementButton, out bool isPressed, buttonThreshold);
            if (isPressed)
            {
                Debug.Log("Button pressed");
            }
            return isPressed;
        }
        else
        {
            return false;
        }

    }*/

    void Update()
    {
        if (rayInteractor != null && rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            if (placementAction.action.WasPressedThisFrame())
            {
                Debug.Log("Turret placed");
                Instantiate(turretPrefab, hit.point, Quaternion.identity);
                //GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
                //turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
            }
        }
    }
}
