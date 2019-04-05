using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    internal static class Extensions
    {
        public static Uri AddSegment(this Uri uri, object segment)
        {
            var builder = new UriBuilder(uri);
            builder.Path = $"{builder.Path}/{segment}";
            return builder.Uri;
        }
    }
}