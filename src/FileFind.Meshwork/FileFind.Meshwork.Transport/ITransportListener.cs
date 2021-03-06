//
// ITransportListener.cs:
//
// Authors:
//   Eric Butler <eric@extremeboredom.net>
//
// (C) 2006 FileFind.net (http://filefind.net)
//

using System;

namespace FileFind.Meshwork.Transport
{
	public interface ITransportListener
	{
		void StartListening ();
		void StopListening ();
	}

	public class FailedTransportListener
	{
		public ITransportListener Listener;
		public Exception          Error;

		public FailedTransportListener (ITransportListener listener, Exception error)
		{
			this.Listener = listener;
			this.Error    = error;
		}
	}
}
