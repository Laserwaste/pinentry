int PIN ;
do
{
     Console.WriteLine("Enter your PIN: (must be between 1000 and 9999) ");
     PIN = int.Parse(Console.ReadLine());
     if (PIN < 1000 || PIN > 9999)
     {
         Console.WriteLine("Invalid PIN. Please try again.");
     }
}
while (PIN < 1000 || PIN > 9999);