using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLightProbes : MonoBehaviour
{
    private bool lit = true;
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = gameObject.GetComponent<MeshRenderer>();
        mr.lightProbeUsage = UnityEngine.Rendering.LightProbeUsage.BlendProbes;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (lit)
                mr.lightProbeUsage = UnityEngine.Rendering.LightProbeUsage.Off;
            else
                mr.lightProbeUsage = UnityEngine.Rendering.LightProbeUsage.BlendProbes;
            lit = !lit;
        }
    }
}
