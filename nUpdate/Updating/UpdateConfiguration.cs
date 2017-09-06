﻿// Copyright © Dominic Beger 2017

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using nUpdate.Core;
using nUpdate.Core.Operations;

namespace nUpdate.Updating
{
    [Serializable]
    public class UpdateConfiguration : IDeepCopy<UpdateConfiguration>
    {
        /// <summary>
        ///     The architecture settings of the update package.
        /// </summary>
        public Architecture Architecture { get; set; }

        /// <summary>
        ///     The whole changelog of the update package.
        /// </summary>
        public Dictionary<CultureInfo, string> Changelog { get; set; }

        /// <summary>
        ///     The literal version of the package.
        /// </summary>
        public string LiteralVersion { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the update package should be favored over other packages, even if they have
        ///     a higher <see cref="UpdateVersion" />.
        /// </summary>
        public bool NecessaryUpdate { get; set; }

        /// <summary>
        ///     The operations of the update package.
        /// </summary>
        public List<Operation> Operations { get; set; }

        /// <summary>
        ///     The signature of the update package (Base64 encoded).
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        ///     The unsupported versions of the update package.
        /// </summary>
        public string[] UnsupportedVersions { get; set; }

        /// <summary>
        ///     The URI of the update package.
        /// </summary>
        public Uri UpdatePackageUri { get; set; }

        /// <summary>
        ///     The URI of the PHP-file which does the statistic entries.
        /// </summary>
        public Uri UpdatePhpFileUri { get; set; }

        /// <summary>
        ///     Sets if the package should be used within the statistics.
        /// </summary>
        public bool UseStatistics { get; set; }

        /// <summary>
        ///     The version ID of this package to use in the statistics, if used.
        /// </summary>
        public int VersionId { get; set; }

        /// <summary>
        ///     Performs a deep copy of the current <see cref="UpdateConfiguration" />-instance.
        /// </summary>
        /// <returns>Returns a copy of the given <see cref="UpdateConfiguration" />-instance.</returns>
        public UpdateConfiguration DeepCopy()
        {
            return (UpdateConfiguration) MemberwiseClone();
        }

        /// <summary>
        ///     Downloads the update configurations from the server.
        /// </summary>
        /// <param name="configFileUri">The url of the configuration file.</param>
        /// <param name="proxy">The optional proxy to use.</param>
        /// <param name="cancellationTokenSource">The optional <see cref="CancellationTokenSource"/> to use for canceling the operation.</param>
        /// <returns>Returns an <see cref="IEnumerable{UpdateConfiguration}" /> containing the package configurations.</returns>
        public static IEnumerable<UpdateConfiguration> Download(Uri configFileUri, WebProxy proxy, CancellationTokenSource cancellationTokenSource = null)
        {
            return Download(configFileUri, null, proxy, cancellationTokenSource);
        }

        /// <summary>
        ///     Downloads the update configurations from the server.
        /// </summary>
        /// <param name="configFileUri">The url of the configuration file.</param>
        /// <param name="credentials">The HTTP authentication credentials.</param>
        /// <param name="proxy">The optional proxy to use.</param>
        /// <param name="cancellationToken">The optional <see cref="CancellationTokenSource"/> to use for canceling the operation.</param>
        /// <returns>Returns an <see cref="IEnumerable{UpdateConfiguration}" /> containing the package configurations.</returns>
        public static IEnumerable<UpdateConfiguration> Download(Uri configFileUri, NetworkCredential credentials,
            WebProxy proxy, CancellationTokenSource cancellationTokenSource = null)
        {
            using (var wc = new WebClientWrapper(10000))
            {
                wc.Encoding = Encoding.UTF8;
                if (credentials != null)
                    wc.Credentials = credentials;

                if (proxy != null)
                    wc.Proxy = proxy;

                // Register the cancel async method of the webclient to be called
                cancellationTokenSource?.Token.Register(wc.CancelAsync);

                // Check for SSL and ignore it
                ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
                var source = wc.DownloadString(configFileUri);
                if (!string.IsNullOrEmpty(source))
                    return Serializer.Deserialize<IEnumerable<UpdateConfiguration>>(source);
            }

            return Enumerable.Empty<UpdateConfiguration>();
        }

        /// <summary>
        ///     Loads an update configuration from a local file.
        /// </summary>
        /// <param name="filePath">The path of the file.</param>
        public static IEnumerable<UpdateConfiguration> FromFile(string filePath)
        {
            return Serializer.Deserialize<IEnumerable<UpdateConfiguration>>(File.ReadAllText(filePath)) ??
                   Enumerable.Empty<UpdateConfiguration>();
        }
    }
}