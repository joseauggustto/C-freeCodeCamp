// Um valor literal é um valor constante que nunca é alterado.

Console.WriteLine('b'); // Entre aspas simples são caracteres 
                        // e entre aspas duplas são strings (textos).

Console.WriteLine(123); // O número é escrito sem aspas. São chamados de literais numéricos
                        // e representam um valor constante de um tipo de dados numérico.

Console.WriteLine(0.25f); // Adicionar o f no final indica que o número é float.

Console.WriteLine(2.625); // Por padrão, o C# trata números com casas decimais como double.

Console.WriteLine(12.39816m); // O m indica que o número é decimal.

Console.WriteLine(true);
Console.WriteLine(false); // Os valores literais true e false são reservados para o tipo de dados booleano.

// ------------

// Variaveis são espaços de memoria que armazenam dados.

string firstName;
Firstname = "Bob";
Console.WriteLine(firstName);

var message = "Hello World!"; // Var descobre qual é o tipo de dado sozinho.

// ------------

// DESAFIO 2

string name = "Bob";
int message = 3;
float temp = 34.4f;

Console.WriteLine("Hello, " + name + "! You have " + message + " messages in your inbox." + " The temperature is " + temp + " celcius.");



