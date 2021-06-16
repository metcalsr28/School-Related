/*
Allows currency to be converted from various types to US dollars.
Author: Jill Courte for CSE 153 Spring, 2016
// Modified by Steve Metcalf
// Date: 09/27/2019
// Description: Finished document allowing user to input a currency and have converted 
// to US dollars, program will loop until prompted to stop by user
*/
#include <iostream>
#include <string>
using namespace std;
const int USD = 0;
const int EUR = 1;
const int GBP = 2;
const int INR = 3;
const int AUD = 4;
const int CAD = 5;
const int ZAR = 6;
const int NZD = 7;
const int JPY = 8;
double conversionFactor;
//Outputs a menu of currency types for user, returning a constant value
// as defined above representing the selected currency.
int getUserSelection ()
{
    int selection;
    cout << "Available currencies for conversion: " << endl;
    cout << "(1) Euros" << endl;
    cout << "(2) Great Britan Pounds" << endl;
    cout << "(3) Indian Rupees" << endl;
    cout << "(4) Australian Dollars" << endl;
    cout << "(5) Canadian Dollars" << endl;
    cout << "(6) South African Rands" << endl;
    cout << "(7) New Zealand Dollars" << endl;
    cout << "(8) Japanese Zen" << endl;
    cout << "Enter the number of the desired currency to convert: ";
    cin >> selection;
    return selection;
}
//Converts the numeric type to a String representation.
//Use this to output a String representation of the type.
string convertTypeToString(int type)
{
    switch (type)
    {
        case USD:
        conversionFactor = 1;
        return "US Dollars";
        case EUR:
        conversionFactor = 1.08611;
        return "Euros";
        case GBP:
        conversionFactor = 1.44476;
        return "Great Britan Pounds";
        case INR:
        conversionFactor = 0.01495;
        return "Indian Rupees";
        case AUD:
        conversionFactor = 0.69864;
        return "Australian Dollars";
        case CAD:
        conversionFactor = 0.70112;
        return "Canadian Dollars";
        case ZAR:
        conversionFactor = 0.05999;
        return "South African Rands";
        case NZD:
        conversionFactor = 0.65371;
        return "New Zealand Dollars";
        case JPY:
        conversionFactor = 0.00850;
        return "Japanese Zen";
    }
    return "";
}
int main(int argc, char *argv[])
{
    int sentinel = 1;
    while (sentinel > -1)
    {
        int userSelection = getUserSelection();
        string selectionAsAString = convertTypeToString(userSelection);
        cout << "You entered " << selectionAsAString << endl;
        cout << "Please enter the amount of " << selectionAsAString << " to convert to US Dollars: ";
        cin.ignore();
        double foreignCurrency;
        cin >> foreignCurrency;
        double conversionTotal = foreignCurrency * conversionFactor;
        cout << "Your total is " << conversionTotal << " US Dollars" << endl;
        cout << "Would you like to make another conversion? Please enter -1 when done!" << endl;
        cin.ignore();
        cin >> sentinel;
    }
}