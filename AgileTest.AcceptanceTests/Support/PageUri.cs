using System;

namespace AgileTest.AcceptanceTests.Support;

[AttributeUsage(AttributeTargets.Class)]
public class PageUri(string uri) : Attribute
{
    public string Uri { get; private set; } = uri;
}