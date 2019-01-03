# CLR not managed code interaption
### interop with Win 32 DLLs
* Platform invocation services
* P/Invoke
### Interop with COM components
COM differs from the .NET Framework object model in several important ways:
* Clients of COM objects must manage the lifetime of those objects; the common language runtime manages the lifetime of objects in its environment.

* Clients of COM objects discover whether a service is available by requesting an interface that provides that service and getting back an interface pointer, or not. Clients of .NET objects can obtain a description of an object's functionality using reflection.

* NET objects reside in memory managed by the .NET Framework execution environment. The execution environment can move objects around in memory for performance reasons and update all references to the objects it moves. Unmanaged clients, having obtained a pointer to an object, rely on the object to remain at the same location. These clients have no mechanism for dealing with an object whose location is not fixed.


### Resources
* [COM Wrappers](https://docs.microsoft.com/en-us/dotnet/framework/interop/com-wrappers)