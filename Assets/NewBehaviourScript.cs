using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 30;
    int level;
    int fullLevel = 99;
    int exp = 1500;
    float strength;
    string playername = "검사";
    string title = "전설의";
    int mana = 25;
    bool isFullLevel = false;

    void Start()
    {
        //1.변수


        //2.그룹형 변수
        string[] monsters = { "슬라임", "악마", "골렘","구울"};
        int[] monsterlevel = new int[4];
        monsterlevel[0] = 1;
        monsterlevel[1] = 6;
        monsterlevel[2] = 20;
        monsterlevel[3] = 5;

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        items.Add("해독제");

        //3.연산자
  

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;
        int nextExp = 300 - (exp % 300);

        isFullLevel = level == fullLevel;
        bool isEndTutorial = level > 10;
        /*
     bool isBadCondition = health <= 50 || mana <= 20;
     string condition = isBadCondition ? "나쁨" : "좋음";

     //5.조건문
     if (condition == "나쁨")
     {
         Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
     }
     else
     {
         Debug.Log("플레이어 상태가 좋습니다.");

     }
     if (isBadCondition && items[0] == "생명물약30")
     {
         items.RemoveAt(0);
         health += 30;
         Debug.Log("생명포션을 사용하였습니다.");
         Debug.Log("현재 체력은 "+health+ "입니다.");
     }
     if (isBadCondition && items[0] == "마나물약30")
     {
         items.RemoveAt(0);
         mana += 30;
         Debug.Log("마나포션을 사용 하였습니다.");
         Debug.Log("현재 마력은 "+mana+" 입니다.");
     }

     switch (monsters[3])
     {
         case "슬라임":
             Debug.Log("소형 몬스터 출현!");
             break;
         case "악마":
             Debug.Log("중형 몬스터 출현!");
             break;
         case "골렘":
             Debug.Log("대형 몬스터 출현!");
             break;
         case "굴":
             Debug.Log("초소형 몬스터 출현!");
             break;
         default:
             Debug.Log("??? 몬스터가 출현!");
             break;
     }
     */

        /* // 반복문
         while(health > 0)
         {
             health--;

             if (health > 0)
             {
                 Debug.Log("독데미지를 입었습니다." + health);
             }
             else
             {
                 Debug.Log("캐릭터가 사망하였습니다.");
             }
             if (health == 10)
             {
                 Debug.Log("해독제 아이템을 사용하였습니다.");
                 items.RemoveAt(0);
                 break;
             }
         }
         */
        for (int count = 0; count< 10; count++)
        {
            health++;
        }

        for (int index = 0; index < monsters.Length; index++)
        {
        }

        foreach (string monster in monsters)
        {
        }

        //7.함수 (메소드)
        Heal();

        for (int index  = 0; index  < monsters.Length; index ++)
        {
        //    Debug.Log("용사는" + monsters[index] + "에게" + Battle(monsterlevel[index]));
        }

        //8.클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다.");

        Debug.Log(player.move());
    }
    void Heal()
    {
        health += 10;
        Debug.Log("힐을 받았습니다." + health);
            }
    string Battle (int monsterlevel)
    {
        string result;
        if (level >= monsterlevel)
            result = "이겼습니다.";
        else
        {
            result = "졌습니다.";

        }
        return result;
    }


}
