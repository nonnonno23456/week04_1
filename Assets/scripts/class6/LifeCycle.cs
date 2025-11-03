using System;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("스크립트 비활성화 상태도 호출");
    }

    private void OnEnable()
    {
        Debug.Log("오브젝트 활성되는 순간 실행됨 최초1회실행 아님 오브젝트 나타날때마다");
    }

    void Start()
    {
        Debug.Log("LifeCycle Start");
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        Debug.Log(" 고정적으로 프래임 유지 물리연산로직 주로 넣음 50프레임 정도");
    }

    void Update()
    {
        Debug.Log("로직을 주로 넣음 가변적 프레임 주로 60프레임 실행");
    }

    void LateUpdate()
    {
        Debug.Log("주로 카메라, 후처리 update 끝난후에 실행됨");
    }
    
    private void OnDisable()
    {
        Debug.Log("오브젝트 비활성되는 순간 실행됨 최초1회실행 아님 오브젝트 나타날때마다 껐다켰다 하는 느낌");
    }

    private void OnDestroy()
    {
        Debug.Log("오브젝트 삭제되는 순간 실행됨 삭제할때 무언가 실행해야할때 씀");
    }
}

