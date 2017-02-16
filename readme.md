#Reference Aliasing in Unity
Reference aliasing is a C# feature described in the following MS documentation:

https://msdn.microsoft.com/en-us/library/ms173212.aspx

In short, it allows conflicting DLLs to be referenced in the same build by wrapping them in an 'alias' namespace.

Aliases must be defined in the compiler arguments, and in Unity, compiler arguments are defined in RSP files:

https://docs.unity3d.com/Manual/PlatformDependentCompilation.html

The flag is:

    -reference:ALIAS=file.dll

As long as this is defined in the Unity RSP file, conflicting DLLs can be uniquely identified by adding to the top of any C# script:

    extern alias ALIAS;

