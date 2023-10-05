using SistemaFinanceiro;
using static System.Console;

int opc;

do
{
    Title = "CONTROLE FINANCEIRO";
    Uteis.MontaMenu();
    opc = Convert.ToInt32(ReadLine());

    if (opc < 1 || opc > 6)
    {
        Clear();
        BackgroundColor = ConsoleColor.Red;
        ForegroundColor = ConsoleColor.White;
        WriteLine();
        Uteis.MontaHeader("INFORME UMA OPÇÃO VÁLIDA!", 'X', 30);
        ResetColor();
    }
    else
    {
        Clear();
        switch (opc)
        {
            case 1:
                Write("Listar");
                break;
            case 2:
                Write("Cadastrar");
                break;
            case 3:
                Write("Editar");
                break;
            case 4:
                Write("Excluir");
                break;
            case 5:
                Write("Relatório");
                break;
        }
    }

} while (opc != 6);






ReadLine();

