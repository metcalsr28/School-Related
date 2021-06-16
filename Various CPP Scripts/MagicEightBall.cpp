/* Magic 8-ball starting code.
Author:  Jill Courte for CSE 153, Spring 2017
Modified by: Steve Metcalf
Description of modifications: Code was modified to request a question from the user and to give a random
                                "Magic" results. This program will end when the user types "x" instead of
                                a question.
*/
#include <iostream>
#include <string>
#include <ctime>


using namespace std;


string getAnswer(string m8Ball[], int nAnswers);


int main()
{
	//define a constant that represents how many answers are in your array (at least 8)
	const int ANSWER_ARRAY_SIZE = 8;
	//declare and initialize an array of strings, representing possible answers from the magic eightball
    string answers[] = {
        "Yes",
        "No",
        "Definitely!",
        "No way!",
        "Maybe!",
        "It's possible...",
        "That's very likely!",
        "Ask again later!"
    };

	srand((unsigned int) time(NULL));

	//loop and ask the user to enter a question or enter "x" to stop
    //use getline to get the question
    string question = "";
    while (question.compare("x"))
    {

        cout << "What is your question? (Enter 'x' to exit)" << endl;
        getline(cin, question);
	    //call getAnswer with your array and number of possible answers to get an answer
        string response = getAnswer(answers, ANSWER_ARRAY_SIZE);
	    //output the answer
        cout << "THE MAGIC EIGHT BALL SEES ALL!" << endl << "THE ANSWER TO YOUR QUESTION IS: " << response << endl;
    }


}


string getAnswer(string m8Ball[], int nAnswers)
{
	int index = rand() % nAnswers;

	return m8Ball[index];
}