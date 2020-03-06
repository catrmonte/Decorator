using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Text text;
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            IRifle rifle = new BasicRifle();
            text.text = "Basic accuracy: " + rifle.GetAccuracy();
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("s"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            text.text = "WithScope accuracy: " + rifle.GetAccuracy();
            Debug.Log("WithScope Accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("t"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(rifle));
            text.text = "Stabilizer + Scope Accuracy: " + rifle.GetAccuracy();
            Debug.Log("Stabilizer + Scope Accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("f"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithMagazine(rifle);
            text.text = "Magazine Accuracy: " + rifle.GetAccuracy();
        }

        if (Input.GetKeyDown("t"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(rifle));
            text.text = "Stabilizer + Scope Accuracy: " + rifle.GetAccuracy();
            Debug.Log("Stabilizer + Scope Accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("a"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(new WithMagazine(rifle)));
            text.text = "Stabilizer + Scope + Mag Accuracy: " + rifle.GetAccuracy();
            Debug.Log("Stabilizer + Scope + Mag Accuracy: " + rifle.GetAccuracy());
        }
    }
}
