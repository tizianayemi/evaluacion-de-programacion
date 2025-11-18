namespace evaluacion
{
    internal class Program
    {
        static void Main()
         string[] = { "lunes","martes","miercoles","jueves","viernes","sabado","domingo"})
        double[]dias=double[7];
        for (int i = 0; i< 7; i++)
            {
            Console.WriteLine($\n===== Día {i + 1}: {dias[i]} =====");
    list<double> temperaturasdias =< double >();
    
	int numMedicion = 1;
while (true)
{ 
    Console.writeline($"ingresetemperatura #{numero} en °c:");
    {
        Console.WriteLine("Ingrese un número.");
        continue;
    }
    if (tempC < -30 || tempC > 50)
    { 
        Console.WriteLine("❌ Temperatura fuera de rango (-30 a 50 °C). Intente nuevamente.");
        continue;
    }
temperaturasDia;

double f = CelsiusAFahrenheit(tempC);
double k = CelsiusAKelvin(tempC);
string clasif = ClasificarTemperatura(tempC);

Console.WriteLine($"Medición #{numMedicion}: {tempC:F2} °C | {f:F2} °F | {k:F2} K | {clasif}");

numMedicion++;

Console.Write("¿Desea ingresar otra temperatura? (S/N): ");
string seguir = Console.ReadLine().ToUpper();

if (seguir != "S") break;
 }
double max = Maximo(temperaturasDia);
double min = Mínimo(temperaturasDia);
double prom = Promedio(temperaturasDia);

promediosDia[i] = prom;
totalMedicionesSemana += temperaturasDia.Count;

Console.WriteLine("\n----- Resumen del día -----");
Console.WriteLine($"Cantidad de mediciones: {temperaturasDia.Count}");
Console.WriteLine($"Máxima: {max:F2} °C");
Console.WriteLine($"Mínima: {min:F2} °C");
Console.WriteLine($"Promedio: {prom:F2} °C");
        }

