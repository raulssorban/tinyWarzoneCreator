using Humanlights.Managers;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.Networking;
[System.Serializable]
public class ServerInfo
{
    public string Name;
    public string Description;
    public string HeaderUrl;
    public string WebsiteUrl;
    public string IP;
    public int Port;
    public int Seed;
    public int MaximumPlayers;
    public int CurrentPlayers;
    public bool IsOfficial;
    public string [] Tags;
    public string [] Players;
    public long Ping;
    public bool IsModded;

}