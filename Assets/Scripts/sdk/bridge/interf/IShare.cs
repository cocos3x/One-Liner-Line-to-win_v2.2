namespace sdk.bridge.interf
{
	public interface IShare
	{
		void OnGameInit();

		void CheckShare();

		void EnterShare(int from);

		void SetShareAppSwitch(bool open);

		void AddFissionAppListener(ShareAction action);
	}
}
