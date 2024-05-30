using Builder;
using static System.Console;

var builder = new HtmlBuilder("ul");
builder.AddChild("li", "hello");
builder.AddChild("li", "world");
WriteLine(builder);

builder.Clear();
WriteLine(builder);