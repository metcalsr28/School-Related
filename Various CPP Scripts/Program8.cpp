/*
    Author: Steve Metcalf
    Class: CSE 153
    Date: 10/12/2019
    Description: This assignment fulfills the requirements of Program 8 for class CSE 153
*/

#include <iostream>
#include <iomanip>


using namespace std;

double widthAtTemperature(double widthAt70C, double testTemperature);

int main()
{
    double width;
    double tolerance;
    cout << "Enter the bar width at 70 degrees F: ";
    //cin.ignore();
    cin >> width;
    cout << "Enter the tolerance for width variation: ";
    //cin.ignore();
    cin >> tolerance;

    cout << "Temperature" << setw(20) << "Width" << endl;
    cout << "(Degrees F)" << setw(20) << "(cm)" << endl;

    for (double x = 60; x < 86; x++)
    {
        double nextWidth = widthAtTemperature(width, x);
        cout << x << setw(30) << nextWidth;
        if ((nextWidth > width - tolerance) && (nextWidth < width + tolerance))
        {
            cout << setw(5) << "*" << endl;
        }else
        {
            cout << endl;
        }

    }

}

double widthAtTemperature(double widthAt70C, double testTemperature)
{
    /*
        *****Equation for variation of width with temperature*****
        new width = width(at 70 degrees F)  + (temperature - 70) * 10-4
    */
    return widthAt70C + ((testTemperature - 70) * 0.0001);
}


