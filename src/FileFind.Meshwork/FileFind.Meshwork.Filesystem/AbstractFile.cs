//
// AbstractFile.cs
//
// Authors:
//   Eric Butler <eric@extremeboredom.net>
//
// (C) 2009 FileFind.net (http://filefind.net)
//

using System;
using System.Collections.Generic;

namespace FileFind.Meshwork.Filesystem
{
	public abstract class AbstractFile : IFile
	{
		public abstract string InfoHash {
			get;
			internal set;
		}
		
		public abstract string[] Pieces {
			get;
			internal set;
		}
		
		public abstract int PieceLength {
			get;
			internal set;
		}
		
		public virtual string FullPath {
			get { return PathUtil.Join(Parent.FullPath, Name); }
		}
		
		public abstract long Size {
			get;
		}		

		public abstract string Name {
			get;
		}
		
		public abstract string Type {
			get;
		}
		
		public abstract Dictionary<string, string> Metadata {
			get;
		}
		
		public abstract IDirectory Parent {
			get;
		}
	}
}
