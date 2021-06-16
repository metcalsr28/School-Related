/*Program to deterine if a given pollutant emission is within allowable levels.
Author: Steven Metcalf
Coauthor:  Jill Courte for CSE 135, Spring 2015
*/

#include <iostream>
#include <string>

const int FIRST_STAGE_MILEAGE = 50000;
const int SECOND_STAGE_MILEAGE = 100000;
const int ZERO_MILEAGE = 0;
const int CARBON_MONOXIDE = 1;
const int HYDROCARBON = 2;
const int NITROGEN_OXIDE = 3;
const int NONMETHANE_HYDROCARBON = 4;
const int STOP = 0;

const double CARBON_MONOXIDE_ALLOWED1 = 3.4;
const double CARBON_MONOXIDE_ALLOWED2 = 4.2;

const double HYDROCARBON_ALLOWED1 = 0.31;
const double HYDROCARBON_ALLOWED2 = 0.39;

const double NITROGEN_OXIDE_ALLOWED1 = 0.4;
const double NITROGEN_OXIDE_ALLOWED2= 0.5;

const double NONMETHANE_HYDROCARBON_ALLOWED1 = 0.25;
const double NONMETHANE_HYDROCARBON_ALLOWED2 = 0.31;



using namespace std;

void outputMenu ();
//function prototypes to get allowable level and determine if within bounds
double getAllowableLevel (double gramsPerMileAllowed1, double gramsPerMileAllowed2, int odometer);



int main (int argc, char *argv[])
{
	bool timeToStop = false;
	while (!timeToStop)
	{
		int pollutant;
		double gramsPerMile;
		int odometer;
		bool compliant;
		double allowableGramsPerMile;

		outputMenu();
		cout << "Enter pollutant number: ";
		cin >> pollutant;

		if (pollutant == STOP)
		{
			cout << "Good Bye!" << endl;
			timeToStop = true;
			continue;
		}

		cout << "Enter grams emitted per mile: ";
		cin >> gramsPerMile;
		cout << "Enter odometer reading: ";
		cin >> odometer;

		switch (pollutant)
		{
		case CARBON_MONOXIDE:
			if (odometer > SECOND_STAGE_MILEAGE || odometer < ZERO_MILEAGE)
			{
				cout << "Invalid Odometer Reading, Please Try Again!" << endl << endl;
				continue;
			}
			allowableGramsPerMile = getAllowableLevel(CARBON_MONOXIDE_ALLOWED1, CARBON_MONOXIDE_ALLOWED2, odometer);
			break;
		case HYDROCARBON:
			if (odometer > SECOND_STAGE_MILEAGE || odometer < ZERO_MILEAGE)
			{
				cout << "Invalid Odometer Reading, Please Try Again!" << endl << endl;
				continue;
			}
			allowableGramsPerMile = getAllowableLevel(HYDROCARBON_ALLOWED1, HYDROCARBON_ALLOWED2, odometer);
			break;
		case NITROGEN_OXIDE:
			if (odometer > SECOND_STAGE_MILEAGE || odometer < ZERO_MILEAGE)
			{
				cout << "Invalid Odometer Reading, Please Try Again!" << endl << endl;
				continue;
			}
			allowableGramsPerMile = getAllowableLevel(NITROGEN_OXIDE_ALLOWED1, NITROGEN_OXIDE_ALLOWED2, odometer);
			break;
		case NONMETHANE_HYDROCARBON:
			if (odometer > SECOND_STAGE_MILEAGE || odometer < ZERO_MILEAGE)
			{
				cout << "Invalid Odometer Reading, Please Try Again!" << endl << endl;
				continue;
			}
			allowableGramsPerMile = getAllowableLevel(NONMETHANE_HYDROCARBON_ALLOWED1, NONMETHANE_HYDROCARBON_ALLOWED2, odometer);
			break;
		}

		string compliance;

		compliant = gramsPerMile <= allowableGramsPerMile;
		if (compliant)
			compliance = "within";
		else
			compliance = "exceeds";

		cout << "Emissions " << compliance << " allowable level of " << allowableGramsPerMile << " grams/mile" << endl;

		cin.ignore();
		cin.get();
	
	}
}


void outputMenu ()
{
	cout << "(" << CARBON_MONOXIDE << ") Carbon monoxide" << endl;
	cout << "(" << HYDROCARBON << ") Hydrocarbons" << endl;
	cout << "(" << NITROGEN_OXIDE << ") Nitrogen oxides" << endl;
	cout << "(" << NONMETHANE_HYDROCARBON << ") Non-methane hydrocarbons" << endl;
	cout << "(" << STOP << ") Quit" << endl;
}


//Given an odometer reading, returns the allowable level
double getAllowableLevel (double gramsPerMileAllowed1, double gramsPerMileAllowed2, int odometer)
{
	if (odometer <= FIRST_STAGE_MILEAGE)
	{
		return gramsPerMileAllowed1;
	}
	else
	{
	    return gramsPerMileAllowed2;
	}
}
