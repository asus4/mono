//
// System.Resources.ResourceWriter.cs
//
// Author:
//	Duncan Mak <duncan@ximian.com>
//
// 2001 (C) Ximian, Inc. 	http://www.ximian.com
//

namespace System.Resources {
	   public sealed class ResourceWriter : IResourceWriter {

			 public ResourceWriter (Stream stream) {
				    if (stream == null)
						  throw new ArgumentNullException ("stream is null");
				    if (stream.CanWrite == false)
						  throw new ArgumentException ("stream is not writable.");
			 }

			 public ResourceWriter (String fileName) {
				    if (fileName == null)
						  throw new ArgumentNullException ("fileName is null.");
			 }
			 
			 public void AddResource (string name, byte[] value) {
				    if (name == null || value == null)
						  throw new ArgumentNullException ("Parameter is a null reference.");
			 }
			 public void AddResource (string name, object value) {
				    if (name == null || value == null)
						  throw new ArgumentNullException ("Parameter is a null reference.");
			 }
			 public void AddResource (string name, string value) {
				    if (name == null || value == null)
						  throw new ArgumentNullException ("Parameter is a null reference.");
			 }
				    
			 public void Close () {}
			 
			 public void Dispose () {
				    Close();
			 }
			 public void Generate () {}
	   }
}
