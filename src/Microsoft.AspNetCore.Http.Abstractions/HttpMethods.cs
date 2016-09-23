// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Http
{
    public static class HttpMethods
    {
        public const string Connect = "CONNECT";
        public const string Delete = "DELETE";
        public const string Get = "GET";
        public const string Options = "OPTIONS";
        public const string Patch = "PATCH";
        public const string Post = "POST";
        public const string Put = "PUT";
        public const string Trace = "TRACE";

        public static bool Equals(string firstMethod, string secondMethod)
        {
            return StringComparer.OrdinalIgnoreCase.Equals(firstMethod, secondMethod);
        }
    }
}
