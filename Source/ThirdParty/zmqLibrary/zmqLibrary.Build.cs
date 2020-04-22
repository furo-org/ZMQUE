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
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "x64", "Release","libzmq-mt-4_3_1.lib"));
            //Console.WriteLine("... ZMQ Public Additional Library Path -> " + Path.Combine(ModuleDirectory, "x64", "Release"));

      // Delay-load the DLL, so we can load it from the right place first
      PublicDelayLoadDLLs.Add("libzmq-mt-4_3_1.dll");
		}
        //else if (Target.Platform == UnrealTargetPlatform.Mac)
        //{
        //    PublicDelayLoadDLLs.Add(Path.Combine(ModuleDirectory, "Mac", "Release", "libExampleLibrary.dylib"));
        //}
	}
}
