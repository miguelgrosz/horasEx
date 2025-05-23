Console.WriteLine("------Lucro Extras(Mês)------");

Console.WriteLine("--------Salário por Hora--------");
decimal salarioHora = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("------Horas Trabalhadas------");
decimal horasTrabalhadas = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("------Horas Extras------");
decimal horasExtras = Convert.ToDecimal(Console.ReadLine());

decimal salarioBase = salarioHora * horasTrabalhadas;
decimal valorHoraExtra = salarioHora * 1.4m;
decimal salarioHorasExtras = valorHoraExtra * horasExtras;

decimal salarioTotal = salarioBase + salarioHorasExtras;

Console.WriteLine("Seu Ganho Total foi: R$ " + salarioTotal.ToString("F2"));