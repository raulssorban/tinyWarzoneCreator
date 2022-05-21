using Humanlights;
using Humanlights.Extensions;
using Humanlights.Managers;
using Humanlights.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using tinyWarzone.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bootstrap : HumanlightsSingleton<Bootstrap>
{
    public Canvas Canvas;
    public float ProcessTimeout = 0.5f;
    public float ConfigTimeout = 0.1f;
    public float BundleCheckTimeout = 0.1f;
    public float BundleLoadTimeout = 0.25f;
    public float TimerRate;

}