/*
Author: Steve Metcalf
* Class: CSE 153
* Date: 10/10/2019
* Description: This assignment fulfills the requirements of Program 7 for class CSE 153

Functions introduction, getGuess, and testGuess need to be completed.
Range of numbers to guess needs to be set.
Code needs to be added to ask if user wants another game and loop control set accordingly.
Code needs to be added to track number of guesses.


*/

#include <iostream>


using namespace std;


void introduction(int high, int low);
int getGuess();
bool testGuess(int guess, int numberToGuess);
void closing();


int main(int argc, char *argv[])
{
	int high = 7;
	int low = 1;

	int numberToGuess;
	int stillPlaying = 1;
	bool winner = false;

	int guess;
	int numberOfGuesses;

	while (stillPlaying == 1)
	{
		// generate a random number between low and high value
		numberToGuess = rand() % (high - low + 1) + low;

		//tell the user about the game
		introduction(high, low);
		numberOfGuesses = 0;
		winner = false;
		while (!winner)
		{
			guess = getGuess();
			numberOfGuesses++;
			winner = testGuess(guess, numberToGuess);
			if (winner)
			{
				//output a congratulatory message
				cout << "You did it! Good job!" << endl;
			}
			else
				;
			//output the number of guesses they've made so far
			cout << "Guesses: " << numberOfGuesses << endl;
		}

		//ask the user if they want to play again, and if not, change the loop control condition
		cout << "Would you like to play again? Please enter 1 for yes or 0 for no" << endl;
		cin.ignore();
		cin >> stillPlaying;

	}

	closing();

}





//Tells the user the ruules of the game
void introduction(int high, int low)
{
	cout << endl << "I'm thinking of a number between " << low << " and " << high << "....." << endl;
}

//Prompts for, inputs, and returns the next guess
int getGuess()
{
	cout << "Please attempt to guess what number I'm thinking of!" << endl;
	int guess;	
	cin >> guess;
	return guess;
}

// returns true if guess is correct
//if guess is not correct, outputs a high or low message and returns false
bool testGuess(int guess, int numberToGuess)
{
	if (numberToGuess == guess)
		return true;
	else if (numberToGuess > guess)
	{
		cout << "Your guess was too low!" << endl;
		return false;
	}
	else if (numberToGuess < guess)
	{
		cout << "Your guess was too High!" << endl;
		return false;
	}
}

void closing()
{
	cout << "Thanks for playing!" << endl;

	cin.ignore();
	cin.get();
}