using UnityEngine;

public static class DongleFactory
{
    public static DongleController CreateDongle(GameObject dongle, int level)
    {
        GameObject newDongle = ObjectPool.Instance.GetFromPool(dongle, PoolTypeEnums.DONGLE);  // 새로운 동글이 생성

        // DongleController 가져오기
        DongleController dongleController = newDongle.GetComponent<DongleController>();  

        dongleController.dongleLevel = level;  // 레벨 설정
        dongleController.PlayAnimation(level);  // 레벨에 맞는 애니메이션 실행

        return dongleController;
    }
}