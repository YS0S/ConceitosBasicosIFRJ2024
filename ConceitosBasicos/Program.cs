// Crie um programa para calcular o IMC de uma pessoa e informar o status de acordo com o IMC calculado

Console.WriteLine("Informe seu peso: ");
int peso = int.Parse(Console.ReadLine());

Console.WriteLine("Informe sua altura");
float altura = float.Parse(Console.ReadLine());

float imc = peso / (altura * altura);

Console.WriteLine($"Para o peso {peso} e a altura {altura} o imc calculado foi {imc:f1}");

string status = string.Empty;
if (imc <= 16.9)
    status = "Muito abaixo do peso";
else if (imc <= 18.4)
    status = "Abaixo do peso";
else if (imc <= 24.9)
    status = "Peso normal";
else if (imc <= 29.9)
    status = "Acima do peso";
else if (imc <= 34.9)
    status = "Obesidade grau I";
else if (imc <= 40)
    status = "Obesidade garu II";
else if (imc <40)
    status = "Obesidade Grau III"