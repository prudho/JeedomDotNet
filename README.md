# JeedomDotNet
JeedomDotNet is an experimental DotNet client library for Jeedom, written in C#. It use the Jeedom JSON RPC 2.0 API or Jeedom HTTP API trough a custom HTTP library.

Current version is 0.0.1.0 (yeah, it's an alpha version). By using it you can expect crashes, and a lot of frustration. Oh, and some things could actually work fine too, but that's not guaranteed.

Anyway, please keep in mind that it's just an early version made by a hobbyist.

## Requirements
[Visual Studio 2015](https://www.visualstudio.com/downloads/download-visual-studio-vs) and its NuGet extension installed.

## Getting Started
* **Get an API key** - to use Jeedom API you need a Jeedom API key.
* Build JeedomDotNet.
* Create an new application that references JeedomDotNet (shell or Windows Desktop, Universal is not tested) with .Net Framework 4.5 or superior.
* Insert this in your Main():

```csharp
Jeedom jee = new Jeedom("your.host", "your.API.key", false, false);

if (jee.Loaded)
{
	// Jeedom OK ! Do something here...
}
else
{
	// An error happen during Jeedom loading, we display it
	Console.Out.WriteLine("Jeedom error : " + jee.Error);
}
```

If you connect to Jeedom trough SSL, you must set the 3rd parameter to true, and if you use a self-signed SSL certificate, you must also set the 4th parameter to true.

If your Jeedom is installed on a custom path, you can use this constructor :

```csharp
// Assuming that you access to your Jeedom via http://jeedom.example.com/jeedom
Jeedom jee = new Jeedom("jeedom.example.com", "/jeedom", "your.API.key", false, false);
```

Default port for conecting to Jeedom is 80 for HTTP and 443 for HTTPS. If you use a custom port you must tell it to the Jeedom constructor :
```csharp
// Assuming that you access to your Jeedom via http://jeedom.example.com:8000/jeedom
Jeedom jee = new Jeedom("jeedom.example.com", 8000, "/jeedom", "your.API.key", false, false);
```

## Examples
*All examples assume you have already wrote the lines above, insert code under the line **// Jeedom OK ! Do something here...** *

Get the Jeedom version:
```csharp
Console.Out.WriteLine("Jeedom version : " + jee.Version);
```

Display the name of all Jeedom objects:
```csharp
foreach (JeedomDotNet.Entities.Object obj in jee.Entities.Objects)
{
	Console.Out.WriteLine(obj.Name);
}
```

Display the name of all Jeedom objects:
```csharp
foreach (JeedomDotNet.Entities.Object obj in jee.Entities.Objects)
{
	Console.Out.WriteLine(obj.Name);
}
```
Display the parent object name of all Jeedom eqlogics:
```csharp
foreach (JeedomDotNet.Entities.EqLogic eq in jee.Entities.EqLogics)
{
	Console.Out.WriteLine("EqLogic " + eq.Name + " has for parent the object " + eq.Parent.Name);
}
```

Start a Jeedom scenario (you must know the scenario id):
```csharp
string return = jee.Scenario(80, Jeedom.ScenarioType.Start);
// return "ok" when the command is good
```

Launch a Jeedom command (you must know the command id):
```csharp
string return = jee.Command(107);
// return the command result
```

Send a custom RPC command
```csharp
string result = RPCCommand("command.name", new Dictionary<string, object>() { { "var1", var1 }, { "var2", var2 }, { "var3", var3 } });
// return the command result that you have to parse (Newtonsoft.Json is your friend)
```