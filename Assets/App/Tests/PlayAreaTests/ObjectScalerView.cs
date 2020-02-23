using AVR.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectScalerView : MonoBehaviour
{
    public Text XValueText;
    public Text ZValueText;

    public Toggle changeLocation;

    public ObjectScaler objectScaler;

    public void OnZChanged(int increment)
    {
        var currentScale = objectScaler.Scale;
        var z = currentScale.z + increment;
        z = Mathf.Clamp(z, 1, 50);
        ZValueText.text = z.ToString();
        currentScale.z = z;
        objectScaler.Scale = currentScale;

    }
    public void OnXChanged(int increment)
    {
        var currentScale = objectScaler.Scale;
        var x = currentScale.x + increment;
        x = Mathf.Clamp(x, 1, 50);
        XValueText.text = x.ToString();
        currentScale.x = x;
        objectScaler.Scale = currentScale;
    }

    public void OnResetClicked()
    {
        objectScaler.ResetScale();
        XValueText.text = 1.ToString();
        ZValueText.text = 1.ToString();
    }
}
