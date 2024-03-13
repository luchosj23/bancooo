namespace Biblioteca;

public class Banco
{
    private string nombre;
    private string apellido;
    private int efectivo;

    public Banco(string unnombre, string unapellido, int unefectivo) 
    => (nombre, apellido, efectivo) = (unnombre, unapellido, unefectivo);
}