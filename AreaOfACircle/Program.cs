Console.WriteLine("Hello! I can help you find the area of a circle, please enter the radius");
double radius = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine("The area of your cirle is: " + area + " Units^2.");

Console.WriteLine("Is there anything else i can help you with?");
Console.ReadLine();
Console.WriteLine("You think i work for free? Insert money to continue");
Console.WriteLine("Enter donation amount");
Console.ReadLine();
Console.WriteLine("Congrats! You just got scammed, goodbye");
