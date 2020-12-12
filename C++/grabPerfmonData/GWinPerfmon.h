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
	GWinPerfmon(LPWSTR serverName);


	// Destruction
	~GWinPerfmon();

	// Public Vars

	// Private Vars
	std::wstring machineName = NULL;
	HQUERY pdhQueryHandle = NULL;
	DWORD userData = 1;

	// Public Methods
	void setMachineName(LPWSTR name);
	
	bool addCounter(LPWSTR counterObject, LPWSTR counterName, LPWSTR counterInstance);
};

