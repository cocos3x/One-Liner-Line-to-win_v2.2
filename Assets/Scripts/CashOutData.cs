using System;

[Serializable]
public class CashOutData
{
	public int queueID;

	public CashOutType type;

	public float amount;

	public int activationTimes;

	public int validTime;

	public long startNtpTime;

	public long targetNtpTime;

	public string startDay;

	public int adNum;

	public int k0;

	public int pDay;

	public CashOutData(int queueID, CashOutType type, float amount, int activationTimes, int validTime)
	{
	}
}
