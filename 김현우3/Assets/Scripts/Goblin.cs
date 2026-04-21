using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


// 고블린에서도 Enemy 클래스를 가져옴
public class Goblin : Enemy
{
    public Goblin() : base("고블린", 50, 8)
    {
    }
}


    // Update is called once per frame
    void Update()
    {

    }
}