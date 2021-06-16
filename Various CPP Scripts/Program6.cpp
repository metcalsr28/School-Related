/*Author: Steve Metcalf
* Class: CSE 153
* Date: 10/04/2019
* Description: This assignment fulfills the requirements of Program 6 for class CSE 153
*/
#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

int main()
{
    cout << "Enter the lower bound of the population in thousands (1 = 1000, 10 = 10,000, etc.): " << endl;
    //cin.ignore();
    int lowerBound;
    cin >> lowerBound;

    cout << "Enter the upper bound of the population in thousands (1 = 1000, 10 = 10,000, etc.): " << endl;
    cin.ignore();
    int upperBound;
    cin >> upperBound;

    cout << "\nPopulation (in thousands)" << "\tFlowrate" << endl;
    while (lowerBound < upperBound + 1)
    {
        cout << setw(10) << lowerBound << setw(30) << ((3.86 * sqrt(lowerBound)) * (1-(0.01 * sqrt(lowerBound)))) << endl;

        lowerBound++;
    
    }
}