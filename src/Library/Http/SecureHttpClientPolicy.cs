using System.Net.Http; namespace Arq.Lab.Library.Http; public static class SecureHttpClientPolicy { public static HttpClientHandler Build() => new HttpClientHandler(); }
