using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold;

    // Update is called once per frame
    void Update()
    {
		if (leftTeleportRay)
		{
            leftTeleportRay.gameObject.SetActive(CheckIfActivated(leftTeleportRay));
		}

		if (rightTeleportRay)
		{
            rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
		}


    }

    public bool CheckIfActivated(XRController controller)
	{
        //teleportActivationButton = InputHelpers.Button.PrimaryButton; // sweeeett!!!! makes use of 'A', 'x' button vs trigger 
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
	}
}
