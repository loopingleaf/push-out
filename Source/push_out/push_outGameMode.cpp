// Copyright Epic Games, Inc. All Rights Reserved.

#include "push_outGameMode.h"
#include "push_outPawn.h"

Apush_outGameMode::Apush_outGameMode()
{
	// set default pawn class to our character class
	DefaultPawnClass = Apush_outPawn::StaticClass();
}

