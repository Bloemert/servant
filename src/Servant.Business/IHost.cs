using Servant.Business.Objects;
using System;

namespace Servant.Business
{
	public interface IHost
	{
		bool LogParsingStarted { get; set; }
		bool Debug { get; set; }
		DateTime StartupTime { get; set; }
		void Start(ServantConfiguration configuration = null);
		void Stop();
		void Kill();
		void StartLogParsing();
		void StopLogParsing();
		void RemoveCertificateBinding(int port);
		void AddCertificateBinding(int port);
	}
}