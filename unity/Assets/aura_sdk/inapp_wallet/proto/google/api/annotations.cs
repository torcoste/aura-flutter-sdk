// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: annotations.proto

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace google.api
{

    public static class Extensions
    {
        public static HttpRule GetHttp(this global::Google.Protobuf.Reflection.MethodOptions obj)
            => obj == null ? default : global::ProtoBuf.Extensible.GetValue<HttpRule>(obj, 72295728);

        public static void SetHttp(this global::Google.Protobuf.Reflection.MethodOptions obj, HttpRule value)
            => global::ProtoBuf.Extensible.AppendValue<HttpRule>(obj, 72295728, value);

    }
}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
