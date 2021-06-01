// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;
using UnrealBuildTool;
using System;

public class zmqLibrary : ModuleRules
{
  public zmqLibrary(ReadOnlyTargetRules Target) : base(Target)
  {
    Type = ModuleType.External;
    if (Target.Platform == UnrealTargetPlatform.Win64)
    {
      // Add the import library
      String LibName = "libzmq-mt-4_3_1";
      PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "x64", "Release",LibName+".lib"));
      // Delay-load the DLL, so we can load it from the right place first
      PublicDelayLoadDLLs.Add(LibName+".dll");
      RuntimeDependencies.Add("$(TargetOutputDir)/"+LibName+".dll",Path.Combine(ModuleDirectory,"x64","Release",LibName+".dll"));
    }
    else if(Target.Platform == UnrealTargetPlatform.Linux){
      PublicSystemLibraries.Add("zmq");
      PublicSystemLibraryPaths.Add("/usr/lib/x86_64-linux-gnu/");
    }
  }
}
