using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : Character
{
    public Dictionary<string, int> items = new Dictionary<string, int>();

    public Player(string name, int health, int attackPower)
        : base(name, health, attackPower)
    {
        items.Add("Potion", 3);
    }

    public override void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(name + "이(가) " + damage + " 데미지를 받았습니다.");

        if (health <= 0)
        {
            health = 0;

            Die();
        }
    }

    public override void Attack(Character target)
    {
        Debug.Log(name + "이(가) " + target.name + "을(를) 공격했습니다");
        target.TakeDamage(attackPower);
    }

    public override void Die()
    {
        Debug.Log(name + "이(가) 죽었습니다.");
    }

    public void UsePotion()
    {
        if (items.ContainsKey("Potion") && items["Potion"] > 0)
        {
            items["Potion"]--;

            health += 20;

            Debug.Log(name + "가 포션을 사용했습니다. 현재 체력 " + health);
        }
        else
        {
            Debug.Log("포션이 없습니다");
        }
    }
}

    // Update is called once per frame
    void Update()
    {

    }
}