namespace PatronesComportamiento._2.Command._2._2CommandPatternERP.Command
{
    //Definimos los tipos de Comandos en ICommandERP que se instanciaran
    public interface ICommandERP
    {
        void Ejecutar();

        void Deshacer();
    }
}