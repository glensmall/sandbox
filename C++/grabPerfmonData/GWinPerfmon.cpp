/*
	Implementation file for the GWinPerfmon Class
*/

#include "GWinPerfmon.h"

// Default Constructor
GWinPerfmon::GWinPerfmon()
{
	// TODO: Add implementation code here if needed
}


// Default Destructor
GWinPerfmon::~GWinPerfmon()
{
	// TODO: clean up some of the memory thats been allocated
	
	
}


// Accessor function to set the machine name
void GWinPerfmon::setMachineName(char* name)
{
	// set our provate variable with the passed in data
	this->machineName = name;
}