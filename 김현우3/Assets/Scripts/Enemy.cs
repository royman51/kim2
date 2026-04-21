using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health, int attackPower) : base(name, health, attackPower)
    {
    }
}

    // Update is called once per frame
    void Update()
    {

    }
}