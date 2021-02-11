namespace Facade.BLL
{
    public interface ICadastro
    {
        void Inserir(object obj);
        void Alterar(int id);
        void Excluir(int id);
        object Consultar(int id);
    }
}
