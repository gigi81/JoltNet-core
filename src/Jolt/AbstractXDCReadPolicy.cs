// ----------------------------------------------------------------------------
// AbstractXDCReadPolicy.cs
//
// Contains the definition of the AbstractXDCReadPolicy class.
// Copyright 2009 Steve Guidi.
//
// File created: 2/25/2009 22:16:52
// ----------------------------------------------------------------------------

using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using Jolt.IO;

namespace Jolt
{
    /// <summary>
    /// Defines the common functionality for all implementations of the
    /// <see cref="IXmlDocCommentReadPolicy"/> interface.
    /// </summary>
    public abstract class AbstractXDCReadPolicy
    {
        #region constructors ----------------------------------------------------------------------

        /// <summary>
        /// Creates a new instance of the <see cref="AbstractXDCReadPolicy"/> class
        /// with a given path to an XML the doc comments file.
        /// </summary>
        /// 
        /// <param name="xmlDocCommentsFullPath">
        /// The full path of the XML doc comments file, managed by this instance.
        /// </param>
        /// 
        /// <param name="fileProxy">
        /// The proxy to the file system.
        /// </param>
        internal AbstractXDCReadPolicy(string xmlDocCommentsFullPath, IFile fileProxy)
        {
            m_xmlDocCommentsFullPath = xmlDocCommentsFullPath;
            m_fileProxy = fileProxy;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AbstractXDCReadPolicy"/> class
        /// with a given path to an XML the doc comments file.
        /// </summary>
        /// 
        /// <param name="xmlDocCommentsFullPath">
        /// The full path of the XML doc comments file, managed by this instance.
        /// </param>
        protected AbstractXDCReadPolicy(string xmlDocCommentsFullPath)
            : this(xmlDocCommentsFullPath, new FileProxy()) { }
        #endregion

        #region internal properties ---------------------------------------------------------------

        /// <summary>
        /// Gets the full path of the XML doc comments.
        /// </summary>
        internal string XmlDocCommentsFullPath
        {
            get { return m_xmlDocCommentsFullPath; }
        }

        /// <summary>
        /// Gets the proxy to the file system.
        /// </summary>
        internal IFile FileProxy
        {
            get { return m_fileProxy; }
        }

        #endregion

        #region protected methods -----------------------------------------------------------------

        /// <summary>
        /// Creates an <see cref="System.Xml.XmlReader"/> for reading the associated XML doc comments.
        /// </summary>
        /// 
        /// <returns>
        /// A new, validating, <see cref="System.Xml.XmlReader"/>initialized to read from the
        /// configured path of the XML doc comments file.
        /// </returns>
        protected XmlReader CreateReader()
        {
            StreamReader stream = null;

            try
            {
                var settings = ReaderSettings;
                stream = m_fileProxy.OpenText(m_xmlDocCommentsFullPath);
                return XmlReader.Create(stream, settings);
            }
            catch
            {
                if (stream != null)
                    stream.Dispose();

                throw;
            }
        }

        #endregion

        #region private fields --------------------------------------------------------------------

        private readonly string m_xmlDocCommentsFullPath;
        private readonly IFile m_fileProxy;

        private static XmlReaderSettings ReaderSettings => _readerSettings ?? (_readerSettings = CreateXmlReaderSettings());

        private static XmlReaderSettings _readerSettings;

        private static XmlReaderSettings CreateXmlReaderSettings()
        {
            var type = typeof(AbstractXDCReadPolicy);
            var ret = new XmlReaderSettings();
            ret.ValidationType = ValidationType.Schema;

            using (Stream schema = type.Assembly.GetManifestResourceStream(type, "Xml.DocComments.xsd"))
            {
                ret.Schemas.Add(XmlSchema.Read(schema, null));
            }

            return ret;
        }

        #endregion
    }
}