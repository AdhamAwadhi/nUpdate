﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace nUpdate
{
    public static class Utility
    {
        public static async Task<double> GetTotalPackageSize(IEnumerable<UpdatePackage> packages)
        {
            double size = 0;
            await packages.ForEachAsync(async p =>
            {
                try
                {
                    var req = WebRequest.Create(p.UpdatePackageUri);
                    req.Method = "HEAD";
                    using (var resp = await req.GetResponseAsync())
                    {
                        var headerValue = resp.Headers.Get("Content-Length");
                        double contentLength;
                        if (double.TryParse(headerValue, out contentLength))
                            size += contentLength;
                        else
                            throw new Exception(
                                $"The size of the package for version {p.Version} could not be determined due to an invalid header value for the content length: {headerValue}");
                    }
                }
                catch
                {
                    size = double.NaN;
                }
            });
            return size;
        }
    }
}