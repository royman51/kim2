using UnityEngine;

public class Character
{

// 변수 선언 (이름,체력,공격력)
    public string Name;

    public int Health;

    public int AttackPower;

    public Character(string name,int health, int attackPower)
    {

        Name = name;

       Health = health;

        AttackPower = attackPower;
    }


    public virtual void TakeDamage(int damage)
    {
// 체력을 받은 데미지만큼 감소
        Health -= damage;
        Debug.Log(Name + "이(가) " + damage + " 데미지를 받았습니다.");
// 만약 체력이 0이라면 사망을 가져옵니다.
        if (Health <= 0)
        {
Health = 0;
       Die();
        }
    }

    public virtual void Attack(Character target)
    {
// 타겟에게 공격력만큼 데미지를 주기위해 위에서 만들어둔 테이크 데미지를 씁니다.
Debug.Log(Name +"이(가) " + target.Name + "을(를) 공격헀습니다");
        target.TakeDamage(AttackPower);
    }

// 대상의 체력이 0이 될때 가져오는 사망 클래스
    public virtual void Die()
    {
        Debug.Log(Name + "이(가)죽었습니다");
    }
}