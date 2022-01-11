using System;

[Serializable]
public enum OrderState
{
	None,
	Activation,
	Verify,
	Progressing,
	Faliure
}
