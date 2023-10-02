//Chapter 14 practice
int a = 10; //Declare a variable "a" on stack
int b = 5; //Declare a variable "b" on stack
int result = Add(a , b); // Call add function to add
Console.WriteLine("Result "  + result);

int Add(int x , int y )
{
    //The x and y values are allocated in this stack within this function
    return x + y; // the result is calculated in the stack
}

// Heap example 
Console.WriteLine("What is your name? ");
string name = Console.ReadLine();
Greeting(name);

void Greeting(string name)
{
    Console.WriteLine("Hi " + name );

}