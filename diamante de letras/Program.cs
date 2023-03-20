namespace diamante_de_letras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int indice = 1;
            char[] letra = alfabeto.ToCharArray();  //pega um caractere por vez do alfabeto
            char letraescolhida = char.Parse(Console.ReadLine().ToUpper());

                    indice += Array.IndexOf(letra, letraescolhida);

                    for (int j = 0; j < indice; j++) //craindo variavel dando valor 0(enquanto variavel for maio =+1
                    {
                        for (int k = 0; k < indice - j; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int l = 0; l < 1; l++)
                        {
                            Console.Write(letra[j]);

                            for (int k = 0; k <= 2 * j - 2; k++) //espaço entre as letras 2*j
                            {
                                Console.Write(" ");
                            }

                            if (j != 0)
                            {
                                Console.Write(letra[j]);
                            }
                            Console.WriteLine();
                        }

                    }
                    for (int j = indice -2; j > -1; j--)   //para fazer o inverso so mecher nesta linha
                    {
                        for (int k = 0; k < indice - j; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int l = 0; l < 1; l++)
                        {
                            Console.Write(letra[j]);

                            for (int k = 0; k <= 2 * j - 2; k++)
                            {
                                Console.Write(" ");
                            }

                            if (j != 0)
                            {
                                Console.Write(letra[j]);
                            }
                            Console.WriteLine();
                        }


                    }





               
        }   
    }
}