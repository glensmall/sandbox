#pragma once
/*
	Class that wraps the PDH functions and allows me to handle perfmon data from the specifiec machine
*/

// includes
#include <string>
#include <pdh.h>


class GWinPerfmon
{
	// Construction
	GWinPerfmon();


	// Destruction
	~GWinPerfmon();

	// Public Vars

	// Private Vars
	std::string machineName;


	// Public Methods
	void setMachineName(char* name);
	
	PDH_STATUS addCounter();
};

