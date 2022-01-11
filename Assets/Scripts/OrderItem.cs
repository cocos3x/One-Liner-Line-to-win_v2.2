using System;

[Serializable]
public class OrderItem
{
	public OrderState orderState;

	public GameType gameType;

	public int money;

	public long cashOutTimer;

	public int activationStartAD;

	public int activationTargetAD;

	public int activationNeedAD;

	public long activationTime;

	public long activationTargetTime;

	public long verifyEnterTimer;

	public long verifyLastExpendTimer;

	public long verifyTime;

	public int verifyDailyTimer;

	public int verifyDailyLimitTimer;

	public long verifyAddTime;

	public int progressingRanking;

	public float ActivationProgress()
	{
		return 0f;
	}

	public long ActivationCountDown()
	{
		return 0L;
	}

	public long VerifyCountDown()
	{
		return 0L;
	}
}
