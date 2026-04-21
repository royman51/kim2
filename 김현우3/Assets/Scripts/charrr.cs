using UnityEngine;

public class Character
{

// 변수 선언 (이름,체력,공격력)
    public string Name;

    public int Health;

    public int AttackPower;

    public Character(string name,int health, int attackPower)


    public abstr void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log(Name + "이(가) " + damage + " 데미지를 받았습니다.");
//체력0 사망


        if (Health <= 0)
        {  
      Health = 0;
       Die();
        }
    }

// 대상의 체력이 0이 될때 나오는 사망
    public virtual void Die()
    {
        Debug.Log(Name + "이 죽었습니다.");
    }
}

    // Update is called once per frame
    void Update()
    {

    }
}