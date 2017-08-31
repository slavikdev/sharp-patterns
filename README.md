# Sharp Patterns
Organize your .NET code with design patterns.

[![Build status](https://ci.appveyor.com/api/projects/status/rkv4b6h0lhe7nltd?svg=true)](https://ci.appveyor.com/project/slavikdev/sharp-patterns)

## Features
* Chains&mdash;implementations of the chain of responsibility pattern.
	* [SimpleTaskChain](https://github.com/slavikdev/sharp-patterns/wiki/SimpleTaskChain)&mdash;executes tasks one by one without any result.
	* [TaskChain](https://github.com/slavikdev/sharp-patterns/wiki/TaskChain)&mdash;executes tasks one by one, passing previous task result to the next task. Returns last task result.
	

## Installation
Nuget package name is `SharpPatterns`.
```
PM> Install-Package SharpPatterns
```
