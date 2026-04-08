using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DictionaryPractice : MonoBehaviour
{
// 왼쪽이 키고, 오른쪽이 값입니다.
// 키와 값의 자료형엔 제한이 없습니다.
    public Dictionary<string, int> library = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        string borrowBook = "";

        // 딕셔너리 값 추가 (딕셔너리 이름.Add(키, 값))
        library.Add("해리포터", 3);
        library.Add("라오루", 5);
        library.Add("어린 왕자", 2);

        // 딕셔너리 값 변경 ( 딕셔너리 이름[키] = 변경할 값 )
        library["해리포터"] = 2;

        // 처음부터 끝까지 돌아요
        // foreach (데이터타입 변수명 in 컬렉션) 
        foreach(KeyValuePair<string , int> book in library)
        {
            Debug.Log("책 제목" + book.Key + "재고" + book.Value);
        }


        if (library.ContainsKey ("해리포터"))
        {
            Debug.Log("해리포터의 현재 재고" + library["해리포터"]);
            
        }

        if (library.ContainsKey(borrowBook) && library[borrowBook] >= 1) ;
        
         borrowBook = "해리포터";

        library[borrowBook]--;

        

        Debug.Log($"{borrowBook} 책을 빌렸습니다.");


        Debug.Log("해리포터의 현재 재고" + library["해리포터"]);

        // 책을 대출하는걸 만들어봐요
        // 빌릴 책 변수를 선언하고 책의 재고가 1권 이상 있어야지 대출할수 있습니다.

        //  int[] arr = new int[3];
        //  foreach (int i in arr)
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
