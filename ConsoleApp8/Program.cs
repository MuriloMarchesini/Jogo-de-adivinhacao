Random x = new Random();
int balas = 0;
int tiro;
int posmarciano = x.Next(1,100);
int dificuldade;
int munição;

Console.WriteLine("Selecione a dificuldade:");
Console.WriteLine("1 - facil (15 balas)\n2 - medio (10 balas)\n3 - dificil (5 balas)");
dificuldade = Convert.ToInt32(Console.ReadLine());

switch (dificuldade)
{
    case 1:
        balas = 15;                     // switch case para definir qual dificuldade
        break;
    case 2:
        balas = 10;
        break;
    case 3:
        balas = 5;
        break;
    default:
        Console.WriteLine("Digite uma opção correta");
        break;
   
}
Console.WriteLine("Seja bem vindo ao jogo - Encontre o Marciano- ");
Console.WriteLine("Ele está escondido em alguma das 100 árvores a sua frente - Atire digitando o numero de 1 a 100");
munição = balas;





for (int i = 0; i < balas; i++) 
{
    
    tiro = Convert.ToInt32(Console.ReadLine());
    if (tiro < posmarciano)
    {
        munição--;
        Console.WriteLine("O marciano está para a direita");
        Console.WriteLine("Balas restantes: " + munição);
    }
    if ( tiro > posmarciano)
    {
        munição--;
        Console.WriteLine("O marciano está para a esquerda");
        Console.WriteLine("Balas restantes: " + munição);
    }
    if (tiro == posmarciano)
    {
        Console.WriteLine("Você acertou e matou o Marciano restando " + munição + " balas");
        
        balas = 0;
    }
    if (munição == 0)
    {
        Console.WriteLine("Suas balas acabaram, vou lhe pegar menino");
        
    }
}
Console.WriteLine("A posição do marciano é " + posmarciano);
Console.ReadKey();

