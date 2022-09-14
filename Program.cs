using OperatorExercise;

Console.WriteLine("Hello again, this is Computer! I want to follow up and show you the meaning behind those few random numbers from the other day.");
Console.WriteLine("So, we have the equation 1+2");
Console.WriteLine(Operator.Add(1, 2));

Console.WriteLine("And now we have 2-1");
Console.WriteLine(Operator.Subtract(1, 2));

Console.WriteLine("Very good! Furthermore, 1x2 would be...?");
Console.WriteLine(Operator.Multiply(1, 2));

Console.WriteLine("And 2/1 would give us?");
Console.WriteLine(Operator.Divide(1, 2));

Console.WriteLine("Yes perfect, and finally, if we were to divide 5/2, what would our remainder be?");
Console.WriteLine(Operator.Module(2, 5));

Console.WriteLine($"Now here is a tricky one, say we want to find the area of a circle, lets use 4 as our radius. The equation we would use is Pi (3.14 rounded) x 4^2");
Console.WriteLine(AreaOfCircle.Properties(4)); 