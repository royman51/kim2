using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class BattleManager : MonoBehaviour
{
    void Start()
    {
// 새 플레이어를 만들고 플레이어의 스탯을 지정합니다.
        Player player = new Player("플레이어1", 100, 15);

// 새 리스트를 만들고 리스트에 슬라임과 고블린을 추가합니다.
        List<Enemy> enemies = new List<Enemy>();

        enemies.Add(new Slime());
        enemies.Add(new Goblin());

// Debug.Log로 전투 시작을 띄웁니다.
        Debug.Log("전투 시작");
        player.Attack(enemies[0]);

        Debug.Log(enemies[0].Name + "의 남은 체력 " + enemies[0].Health);
        player.UsePotion();
    }
}

    // Update is called once per frame
    void Update()
    {

    }
}