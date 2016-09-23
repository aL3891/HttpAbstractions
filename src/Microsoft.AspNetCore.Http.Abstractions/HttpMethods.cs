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

        public static bool IsConnectMethod(string inputMethod)
        {
            return object.ReferenceEquals(Connect ,inputMethod) | StringComparer.OrdinalIgnoreCase.Equals(Connect, inputMethod);
        }

        public static bool IsDeleteMethod(string inputMethod)
        {
            return object.ReferenceEquals(Delete, inputMethod) | StringComparer.OrdinalIgnoreCase.Equals(Delete, inputMethod);
        }

        public static bool IsGetMethod(string inputMethod)
        {
            return object.ReferenceEquals(Get, inputMethod) | StringComparer.OrdinalIgnoreCase.Equals(Get, inputMethod);
        }

        public static bool IsOptionsMethod(string inputMethod)
        {
            return object.ReferenceEquals(Options, inputMethod) | StringComparer.OrdinalIgnoreCase.Equals(Options, inputMethod);
        }

        public static bool IsPatchMethod(string inputMethod)
        {
            return object.ReferenceEquals(Patch, inputMethod) | StringComparer.OrdinalIgnoreCase.Equals(Patch, inputMethod);
        }

        public static bool IsPostMethod(string inputMethod)
        {
            return object.ReferenceEquals(Post, inputMethod) | StringComparer.OrdinalIgnoreCase.Equals(Post, inputMethod);
        }

        public static bool IsPutMethod(string inputMethod)
        {
            return object.ReferenceEquals(Put, inputMethod) | StringComparer.OrdinalIgnoreCase.Equals(Put, inputMethod);
        }

        public static bool IsTraceMethod(string inputMethod)
        {
            return object.ReferenceEquals(Trace, inputMethod) | StringComparer.OrdinalIgnoreCase.Equals(Trace, inputMethod);
        }
    }
}
