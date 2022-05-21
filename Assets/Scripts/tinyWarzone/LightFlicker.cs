using Humanlights.Extensions;
using System.Collections.Generic;
using UnityEngine;
public class LightFlicker : HumanlightsBehaviour
{
    [Tooltip ( "External light to flicker; you can leave this null if you attach script to a light" )]
    public new Light light;
    [Tooltip ( "Minimum random light intensity" )]
    public float minIntensity = 0f;
    [Tooltip ( "Maximum random light intensity" )]
    public float maxIntensity = 1f;
    [Tooltip ( "How much to smooth out the randomness; lower values = sparks, higher = lantern" )]
    [Range ( 1, 50 )]
    public int smoothing = 5;
    // Continuous average calculation via FIFO queue
    // Saves us iterating every time we update, we just change by the delta
    Queue<float> smoothQueue;
    float lastSum = 0;
    /// <summary>
    /// Reset the randomness and start again. You usually don't need to call
    /// this, deactivating/reactivating is usually fine but if you want a strict
    /// restart you can do.
    /// </summary>

}