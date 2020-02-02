using System.IO;

namespace Jolt.IO
{
    /// <summary>
    /// Defaultimplementation of <see cref="IFile"/> which delegates directly to the methods in <c>System.IO.File</c>.
    /// </summary>
    public class FileProxy : IFile
    {
        /// <summary>
        /// Determines whether the specified file exists
        /// </summary>
        /// <param name="path">The file to check</param>
        /// <returns>
        /// true if the caller has the required permissions and path contains the name of an existing file; otherwise, false.
        /// This method also returns false if <paramref name="path"/> is null, an invalid path, or a zero-length string.
        /// If the caller does not have sufficient permissions to read the specified file, no exception is thrown and the method returns false regardless of the existence of path.
        /// </returns>
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// <summary>
        /// Opens an existing UTF-8 encoded text file for reading.
        /// </summary>
        /// <param name="path">The file to be opened for reading</param>
        /// <returns>A <seealso cref="StreamReader"/> on the specified path.</returns>
        public StreamReader OpenText(string path)
        {
            return File.OpenText(path);
        }
    }
}