using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ModdedEntityReferences : HumanlightsBehaviour
{
    public Reference [] References;
    [System.Serializable]
    public struct Reference
    {
        public string Key;
        public GameObject Value;
    }

}