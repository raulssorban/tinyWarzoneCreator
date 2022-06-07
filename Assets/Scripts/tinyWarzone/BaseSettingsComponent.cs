using Humanlights.Unity.UI;
using System;
public class BaseSettingsComponent<T> : HumanlightsListableBehaviour<BaseSettingsComponent<T>>
{
    public HumanlightsLabel Title;
    public virtual void Init () { Refresh (); }
    public virtual void Refresh () { }

}