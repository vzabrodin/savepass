using System;

namespace SavePass.Exceptions
{
	public class FileCorruptException : Exception
	{
		public FileCorruptException() { }
		public FileCorruptException(string message) : base(message) { }
		public FileCorruptException(string message, Exception inner) : base(message, inner) { }
	}
}