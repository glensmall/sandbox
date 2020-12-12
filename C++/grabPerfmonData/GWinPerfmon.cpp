/*
	Implementation file for the GWinPerfmon Class
*/

#include "GWinPerfmon.h"
#include <wchar.h>

// Default Constructor
GWinPerfmon::GWinPerfmon()
{
	// TODO: Add implementation code here if needed
}

// COnstructoir that takes a server name and initialises the package
GWinPerfmon::GWinPerfmon(LPWSTR serverName)
{
	this->machineName = serverName;
}


// Default Destructor
GWinPerfmon::~GWinPerfmon()
{
	if (this->pdhQueryHandle != NULL)
	{
		PdhCloseQuery(&this->userData);
	}
}


// Accessor function to set the machine name
void GWinPerfmon::setMachineName(LPWSTR name)
{
	// set our provate variable with the passed in data
	this->machineName = name;
}


// Method to add a counter to the package
bool GWinPerfmon::addCounter(LPWSTR counterObject, LPWSTR counterName, LPWSTR counterInstance)
{
	// this might be the first time we're here, in which case open the query handle
	if (this->pdhQueryHandle == NULL)
	{
		PDH_STATUS queryStatus = PdhOpenQuery(NULL, this->userData, &this->pdhQueryHandle);

		if (queryStatus != ERROR_SUCCESS)
		{
			return(false);
		}
	}

	// we got this far, os now we need to build the counter path
	PDH_COUNTER_PATH_ELEMENTS pathElements;
	pathElements.szCounterName = counterName;
	pathElements.szInstanceName = counterInstance;
	pathElements.szMachineName = (LPWSTR)this->machineName.c_str();
	pathElements.szObjectName = counterObject;

	// needed to create teh counter path
	DWORD pathLength = MAX_COUNTER_PATH;
	wchar_t* counterPath = new wchar_t[pathLength];

	// now construct the counter path
	PDH_STATUS makeCounterPath = PdhMakeCounterPath(&pathElements, counterPath, &pathLength, 0);

	// check to see of that worked
	if (makeCounterPath != ERROR_SUCCESS)
	{
		// bomb out if it didn't
		return(false);
	}

	// now we have an open query and a counter path, we can add the counter
	//TODO - need to uodate this so that we can track the counters that ahve been added - maybe by name.  COnsider using a dictionary of some 
	// sorts to handel that.  we can add teh counter object to it.

	return(true);
}