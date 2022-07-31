namespace FluentFTP.Servers.Handlers;

public class OrbisGoldHenFtpServer : FtpBaseServer
{
	public override FtpServer ToEnum()
	{
		return FtpServer.OrbisGoldHen;
	}

	public override bool DetectByWelcome(string message)
	{
		return message.Contains("GoldHEN FTP Server");
	}
}