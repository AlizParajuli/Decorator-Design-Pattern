using Decorator_Design_Pattern;

Console.WriteLine("Decorator Design pattern example");

// Create the base component
IComponent<string> component = new ConcreteComponent();

IComponent<string> colorDecorator = new ColorDecorator(component);
IComponent<string> plainDecorator = new PlainDecorator(component);
IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);

//Result
Console.WriteLine("Parent Component: " + component.GetText());
Console.WriteLine("UpperCase Decorator: " + upperCaseDecorator.GetText());
Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
Console.WriteLine("Color Decorator: " + colorDecorator.GetText());

Console.ReadLine();